using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Forms;
using ThesisWork.ViewModels;

namespace ThesisWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //UserName
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Password
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        //Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            var user = LoginViewModel.Login(UserNameTextBox.Text, PasswordTextBox.Text);
            if (user!=null)
            {

                switch (user.Role)
                {
                   
                    case "Администратор":
                        {
                            Hide();
                            AdministratorForm administratorForm = new AdministratorForm();
                            administratorForm.Text = user.FCs+" - Администратор";
                            administratorForm.Show();
                            break;
                        }

                    case "Руководитель практик":
                        {
                            Hide();
                            PracticeHeadForm head = new PracticeHeadForm(user);
                            head.Text = user.FCs+" - Руководитель практики";
                            head.Show();
                            break;
                        }
                    case "Ответственный по практике":
                        {
                            Hide();
                            ResponsibleForm responsible = new ResponsibleForm(user);
                            responsible.Text = user.FCs+" - Ответственный по практике";
                            responsible.Show();
                            break;
                        }
                    case "Зав. Кафедрой":
                        {
                            Hide();
                            HeadDepartamentForm departament = new HeadDepartamentForm(user);
                            departament.Text = user.FCs+" - Зав.Кафедрой";
                            departament.Show();
                            break;
                        }
                }
            }
            else
            {
                Label label1 = new Label();
                label1.Location = new Point(129, 263);

                label1.Text = "Пользователь не найден";
                label1.ForeColor = Color.DarkRed;
                label1.AutoSize = true;
                Controls.Add(label1);
            }
            
        }
        //UserNameBox
        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //PasswordBox
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
      

    }
}
