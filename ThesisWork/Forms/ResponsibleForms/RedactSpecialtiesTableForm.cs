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
    public partial class RedactSpecialtiesTableForm : Form
    {
        PracticeRepository repos = new PracticeRepository();
        
        public RedactSpecialtiesTableForm()
        {
            InitializeComponent();
            dataGridView1.DataSource =repos.GetSpecialties().ToList();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            repos.UpdateSpeciality((IEnumerable<Specialty>)dataGridView1.DataSource);
            repos.Save();
        }
    }
}
