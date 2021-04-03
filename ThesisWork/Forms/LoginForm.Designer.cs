
namespace ThesisWork
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName_Label = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Location = new System.Drawing.Point(109, 35);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(109, 15);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "Имя пользователя";
            this.UserName_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(109, 65);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(109, 128);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.MaxLength = 12;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(176, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(109, 101);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(49, 15);
            this.Password_Label.TabIndex = 3;
            this.Password_Label.Text = "Пароль";
            this.Password_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(149, 166);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(88, 22);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserName_Label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "PMI Practice";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button LoginButton;
    }
}

