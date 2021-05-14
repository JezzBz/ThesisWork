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
    public partial class RedactPracticeTableForm : Form
    {
        PracticeRepository repository = new PracticeRepository();
        public RedactPracticeTableForm()
        {
            InitializeComponent();
            List<PracticeBase> practiceBases= repository.GetAll().ToList();
            if (practiceBases.Count()==0)
            {
                practiceBases.Add(null);
            }
            dataGridView1.DataSource = practiceBases;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (repository.UpdatePracticeBaseTable((IEnumerable<PracticeBase>)dataGridView1.DataSource))
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
