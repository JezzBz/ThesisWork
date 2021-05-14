
using FastMember;
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

namespace ThesisWork.Forms
{
    public partial class PracticeHeadForm : Form
    {
        User User = new User();
        ScheduleRepository scheduleRepository = new ScheduleRepository();
        PracticeRepository practiceRepository = new PracticeRepository();
        public PracticeHeadForm(User user)
        {
            User = user;
            FormClosed += new FormClosedEventHandler(Form_Closed);
            if (user.Role == "Ответственный по практике")
            {
                Button ToResponsible = new Button();
                ToResponsible.Left = 828;
                ToResponsible.Top = 50;
                ToResponsible.Text = "Войти как ответственный по практике";
                ToResponsible.AutoSize = true;
                ToResponsible.Click += ToResponsibleOnClick;

                Controls.Add(ToResponsible);

            }
            else if (user.Role == "Зав. Кафедрой")
            {
                Button ToResponsible = new Button();
                ToResponsible.Left = 828;
                ToResponsible.Top = 50;
                ToResponsible.Text = "Войти как зав. кафедрой";
                ToResponsible.AutoSize = true;
                ToResponsible.Click += ToResponsibleOnClick;

                Controls.Add(ToResponsible);
            }

            InitializeComponent();
            IEnumerable<PracticeSchedule> practiceSchedules = scheduleRepository.ScheduleInfo(user.FCs).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Наименование практики\n\n");
           
            foreach (var item in practiceRepository.SelectBySchdeule(practiceSchedules))
            {
                table.Rows.Add(item);
            }
            dataGridView1.DataSource =table;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            practiceSchedule.DataSource = practiceSchedules;
        }

        private void PracticeHeadForm_Load(object sender, EventArgs e)
        {

        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ToResponsibleOnClick(object sender, EventArgs eventArgs)
        {
            Hide();
            ResponsibleForm responsible = new ResponsibleForm(User);
            responsible.Text = User.FCs + " - Ответственный по практике";
            responsible.Show();
        }
        private void ToDepartamenrOnClick(object sender, EventArgs eventArgs)
        {
            Hide();
            HeadDepartamentForm responsible = new HeadDepartamentForm(User);
            responsible.Text = User.FCs + " - Зав. кафедрой";
            responsible.Show();
        }

        private void PracticeSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scheduleRepository.UpdateRange((IEnumerable<PracticeSchedule>)practiceSchedule.DataSource);
            scheduleRepository.Save();
        }
    }
}
