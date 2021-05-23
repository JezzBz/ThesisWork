using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;
using Word = Microsoft.Office.Interop.Word;
namespace ThesisWork.WordOutput
{
    class WordHelper
    {
        private FileInfo _fileinfo;
        Word.Application app = null;
        public bool Report(string FileName, Dictionary<string, string> items, string SavePath, IEnumerable<System.Data.DataTable> tables = null)
        {
            try
            {




                if (File.Exists(FileName))
                {
                    _fileinfo = new FileInfo(FileName);
                }
                app = new Word.Application();
                Object missing = Type.Missing;

                app.Documents.Open(FileName);

                if (tables != null)
                {
                    foreach (var dataTable in tables)
                    {


                        app.Selection.Find.Execute("<Table>");
                        Word.Range wordRange = app.Selection.Range;

                        var wordTable = app.ActiveDocument.Tables.Add(wordRange,
                            dataTable.Rows.Count + 1, dataTable.Columns.Count);
                        wordTable.AllowAutoFit = true;
                        wordTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        wordTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            wordTable.Cell(1, i + 1).Range.Text = dataTable.Columns[i].ColumnName;
                        }


                        for (var j = 0; j < dataTable.Rows.Count; j++)
                        {
                            for (var k = 0; k < dataTable.Columns.Count; k++)
                            {
                                wordTable.Cell(j + 2, k + 1).Range.Text = dataTable.Rows[j][k].ToString();
                            }
                        }
                    }
                }


                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;


                    find.Replacement.Text = item.Value;
                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                    MatchCase: false,
                    MatchWholeWord: false,
                    MatchWildcards: false,
                    MatchSoundsLike: missing,
                    MatchAllWordForms: false,
                    Forward: true,
                    Wrap: wrap,
                    Format: false,
                    ReplaceWith: missing,
                    Replace: replace
                    );
                }


            



                Object newFilename = Path.Combine(SavePath);
            app.ActiveDocument.SaveAs2(newFilename);
                app.ActiveDocument.Saved = true;
                app.ActiveDocument.Close();

            return true;
        }
            catch (Exception)
            {
                Console.WriteLine("File output Error");
            }
            finally
            {
                if (app != null)
                {
                   
                    app.Quit();
                }
            }
            return false;
        }
    }
}
