using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ThesisWork.Forms.ResponsibleForms;
using ThesisWork.Models;

namespace ThesisWork.Forms
{
    public partial class ResponsibleForm : Form
    {
        User User = new User();
        public ResponsibleForm(User user)
        {
            FormClosed += new FormClosedEventHandler(Form_Closed);
            User = user;
            InitializeComponent();
            
        }

        private void GoToPracticeHead_Click(object sender, EventArgs e)
        {
            Hide();
            PracticeHeadForm practiceHeadForm = new PracticeHeadForm(User);
            practiceHeadForm.Text = User.FCs+" - Руководитель практики";
            practiceHeadForm.Show();
        }

        private void ResponsibleForm_Load(object sender, EventArgs e)
        {

        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RedactPractice_Click(object sender, EventArgs e)
        {
            RedactPracticeTableForm PracticeTableForm = new RedactPracticeTableForm();
            PracticeTableForm.ShowDialog();

        }

        private void ReductSchedule_Click(object sender, EventArgs e)
        {
            
            RedactScheduleTableForm Schedule = new RedactScheduleTableForm();
            Schedule.ShowDialog();
        }

        private void RedactCompetence_Click(object sender, EventArgs e)
        {
            RedactCompetenceTableForm competenceTable = new RedactCompetenceTableForm();
            competenceTable.ShowDialog(); 
        }

        private void RedactTeachers_Click(object sender, EventArgs e)
        {
            RedactTeachersTableForm form = new RedactTeachersTableForm();
            form.ShowDialog();
        }

        private void RedactStudents_Click(object sender, EventArgs e)
        {
            RedactStudentsTableForm form = new RedactStudentsTableForm();
            form.ShowDialog();
        }
    }
}
