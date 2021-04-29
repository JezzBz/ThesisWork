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
    public partial class RedactCompetenceTableForm : Form
    {
        CompetenceRepository repository = new CompetenceRepository();
        public RedactCompetenceTableForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = repository.GetCompetences().ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RedactCompetenceTableForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            repository.UpdateTable((IEnumerable<Competence>)dataGridView1.DataSource);
            repository.Save();
        }
    }
}
