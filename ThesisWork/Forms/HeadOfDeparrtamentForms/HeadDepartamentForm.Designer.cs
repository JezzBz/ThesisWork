
namespace ThesisWork.Forms
{
    partial class HeadDepartamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти как руководитель практики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(14, 28);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(171, 68);
            this.DeleteData.TabIndex = 9;
            this.DeleteData.Text = "Отчеты по практикам";
            this.DeleteData.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(210, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 68);
            this.button5.TabIndex = 10;
            this.button5.Text = "Формирование сводных отчётов";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 68);
            this.button6.TabIndex = 11;
            this.button6.Text = "Аккредитация";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 68);
            this.button2.TabIndex = 12;
            this.button2.Text = "Отчет по преподавателям";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HeadDepartamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.button1);
            this.Name = "HeadDepartamentForm";
            this.Load += new System.EventHandler(this.HeadDepartamentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}