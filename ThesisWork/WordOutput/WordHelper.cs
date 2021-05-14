using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
namespace ThesisWork.WordOutput
{
    class WordHelper
    {
        private FileInfo _fileinfo;
        Word.Application app = null;
        public bool Report(string FileName,Dictionary<string,string> items,string SavePath)
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
            Object newFilename = Path.Combine(SavePath,"Отчёт");
            app.ActiveDocument.SaveAs2(newFilename);
            app.ActiveDocument.Close();
            
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("File output Error");  
            }
            finally
            {
                if (app!=null)
                {
                    app.Quit();
                }
            }
            return false;
        }
    }
}
