using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                teachers.Add(null);
            }
            dataGridView1.DataSource = teachers;
            dataGridView1.Refresh();
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            label1.AutoSize = true;
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
    }
}
