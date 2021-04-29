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
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Models;
using ThesisWork.Parsers;
using ThesisWork.Repository;
using ThesisWork.ViewModels;

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactStudentsTableForm : Form
    {
        #region Variables
        StudentsParser parser = new StudentsParser();
        StudentsViewModel viewModel = new StudentsViewModel();
        Label label1 = new Label();
        StudentRepository repos = new StudentRepository();

        bool WasChanged = false;
        #endregion
        public RedactStudentsTableForm()
        {
            
           
            FormClosing += Form_Closing;
            InitializeComponent();
            foreach (var item in repos.SelectYears())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            
            if (WasChanged)
            {

                UnchangedDialogForm unchanged = new UnchangedDialogForm();

                if (unchanged.ShowDialog() == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    WasChanged = false;
                    unchanged.Dispose(); 
                    Close();
                }
                
            }
        }
        private void RedactSudentsTableForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label1.AutoSize = true;
            
         
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.DataSource = viewModel.SortByYear(viewModel.SelectAll().ToList());
           
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Excel 97-15.0 WorkBook|*.xls*";

            DataTableCollection data;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

               
                using (var stream = File.Open(FileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        textBox1.Text = FileDialog.FileName;
                        DataSet result = reader.AsDataSet();
                        data = result.Tables;
                        DataTable Table = data[0];
                        
                        bool request=parser.ParseStudentsfromExcel(Table.Rows,FileDialog.FileName);
                        if (request)
                        {
                            label1.Text = "";
                            textBox1.BackColor = Color.Green;
                            button1.Enabled = true;    
                        }
                        else
                        {
                            textBox1.BackColor = Color.Yellow;
                            label1.Location = new Point(570, 55);
                           // label1.Text = "Невалидный файл";
                          //  label1.ForeColor = Color.Red;
                            label1.AutoSize = true;
                            Controls.Add(label1);
                            button1.Enabled = true;
                        }

                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (viewModel.UpdateTable((IEnumerable<Student>)dataGridView1.DataSource) )
            {
                if (viewModel.Apply())
                {
                    label1.Location = new Point(600, 55);
                    label1.Text = "";
                    Controls.Add(label1);
                    label1.Text = "Успешно";
                    label1.ForeColor = Color.Green;
                    Controls.Add(label1);
                    dataGridView1.DataSource = viewModel.SelectAll().ToList();
                    WasChanged = false;
                }

            }
            else
            {
               
                label1.Location = new Point(555, 55);
                label1.Text = "Ошибка обновления базы данных";
                label1.ForeColor = Color.Red;
                label1.AutoSize = true;
                Controls.Add(label1);
                WasChanged = true;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            WasChanged = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = dataGridView1[4, i].Value.ToString() == comboBox1.Text;
            }
            
            
            
            
        }
    }
}
