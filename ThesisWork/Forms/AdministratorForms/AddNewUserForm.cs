using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ThesisWork.ViewModels;

namespace ThesisWork.Forms
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
           
            InitializeComponent();
            RoleComboBox.Items.Add("Руководитель практик");
            RoleComboBox.Items.Add("Ответственный по практике");
            RoleComboBox.Items.Add("Зав. Кафедрой");
            RoleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
         
            if (LoginTextBox.TextLength > 0 && PasswordTextBox.TextLength > 0 && NameTextBox.TextLength > 0 && SurnameTextBox.TextLength > 0 && PatronymicTextBox.TextLength > 0 && RoleComboBox.SelectedItem!=null)
            {

                if (UserViewModel.Add(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, RoleComboBox.SelectedItem.ToString()))
                {


                    MessageLabel.Text = "Пользователь добавлен";
                    MessageLabel.ForeColor = Color.DarkGreen;
                    
                }
                else
                {

                    MessageLabel.Text = "Ошибка!";
                    MessageLabel.ForeColor = Color.DarkRed;
                  
                }
            }
            else
            {
                MessageLabel.Text = "Заполните все поля";
                MessageLabel.ForeColor = Color.DarkRed;
                
            }

        }
    }
}
