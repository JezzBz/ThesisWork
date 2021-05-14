using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Models;
using ThesisWork.Repository;

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactTeachersTableForm : Form
    {
        TeachersRepository repository = new TeachersRepository();
        
        public RedactTeachersTableForm()
        {
            InitializeComponent();
            List<Teacher> teachers = repository.GetAll().ToList();
            if (teachers.Count()==0)
            {
                Teacher teacher = new Teacher();
                teachers.Add(teacher);
            }
            dataGridView1.DataSource = teachers;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            KeyPreview = true;
            label1.AutoSize = true;

            KeyDown += OnKeyDown;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dr = dataGridView1.DataSource as DataTable;
                Teacher teacher = new Teacher();
                dr.Rows.Add(teacher);
               
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void RedactTeachersTableForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (repository.UpdateTable((IEnumerable<Teacher>)dataGridView1.DataSource))
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Успешно!";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Ну удалось обновить данные";
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
