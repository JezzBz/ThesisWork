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

namespace ThesisWork.Forms
{
    public partial class HeadDepartamentForm : Form
    {
        User User = new User();
        public HeadDepartamentForm(User user)
        {
            User = user;
            FormClosed += new FormClosedEventHandler(Form_Closed);
            InitializeComponent();
            
        }

        private void HeadDepartamentForm_Load(object sender, EventArgs e)
        {

        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PracticeHeadForm form = new PracticeHeadForm(User);
            Hide();
            form.Show();
        }
    }
}
