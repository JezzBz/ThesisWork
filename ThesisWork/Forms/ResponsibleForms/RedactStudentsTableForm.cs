using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Parsers;

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactStudentsTableForm : Form
    {
        public RedactStudentsTableForm()
        {
            InitializeComponent();
        }

        private void RedactSudentsTableForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Excel 97-15.0 WorkBook|*.xls*";

            DataTableCollection data;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(FileDialog.FileName, FileMode.Open, FileAccess.Read))
                {



                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {

                        DataSet result = reader.AsDataSet();
                        data = result.Tables;
                        DataTable Table = data[0];
                        StudentsParser parser = new StudentsParser();
                        parser.ParseStudentsfromExcel(Table.Rows);


                    }
                }
            }

        }
    }
}
