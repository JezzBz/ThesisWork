using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Models;
using ThesisWork.Parsers;
using ThesisWork.Repository;
using ThesisWork.ViewModels;

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactScheduleTableForm : Form
    {
        PracticeRepository practiceRepository = new PracticeRepository();
        ScheduleRepository scheduleRepository = new ScheduleRepository();
        CompetenceRepository competenceRepository = new CompetenceRepository();
        string fileName;
        bool changeMarker;
        int auditorehours = 4;
        public RedactScheduleTableForm()
        {
            
            InitializeComponent();
            textBox1.Text = "4";


        }

        private void ChangeTable_Click(object sender, EventArgs e)
        {



            scheduleRepository.UpdateRange((IEnumerable<PracticeSchedule>)PracticeSchedule.DataSource);
            if (changeMarker)
            {
                DataTableCollection data;
                ScheduleRepository repository = new ScheduleRepository();
                using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {

                        DataSet result = reader.AsDataSet();
                        data = result.Tables;
                        
                        ScheduleParser.ParseScheduleFromExcel(data, practiceRepository, scheduleRepository, competenceRepository,auditorehours);
                        scheduleRepository.Save();
                    }


                }
                PracticeSchedule.DataSource = scheduleRepository.SelectAll().ToList();
            }
         

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Excel 97-15.0 WorkBook|*.xls*";
            changeMarker=false;
        
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = File.Open(FileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        textFileName.Text = FileDialog.FileName;
                        fileName = FileDialog.FileName;
                        changeMarker = true;
                    }
                }
                catch (IOException)
                {
                    textBox1.Text = "";
                    label1.Location = new Point(530, 55);
                    label1.Text = "Файл занят другим процессом!";
                    label1.ForeColor = Color.Red;
                    label1.AutoSize = true;
                    Controls.Add(label1);
                }
            }

        }

        private void RedactScheduleTableForm_Load(object sender, EventArgs e)
        {
            PracticeSchedule.ReadOnly = false;
            PracticeSchedule.DataSource = scheduleRepository.SelectAll().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            auditorehours = int.Parse(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)&&number!=8)
            {
                e.Handled = true;
            }
        }

        private void PracticeSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
