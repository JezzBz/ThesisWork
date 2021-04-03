
namespace ThesisWork.Forms
{
    partial class ResponsibleForm
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
            this.RedactPractice = new System.Windows.Forms.Button();
            this.RedactTeachers = new System.Windows.Forms.Button();
            this.RedactStudents = new System.Windows.Forms.Button();
            this.RedactCompetence = new System.Windows.Forms.Button();
            this.ReductSchedule = new System.Windows.Forms.Button();
            this.CreatePracticePlan = new System.Windows.Forms.Button();
            this.CreateServiceNote = new System.Windows.Forms.Button();
            this.CreateReport = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.GoToPracticeHead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RedactPractice
            // 
            this.RedactPractice.Location = new System.Drawing.Point(32, 16);
            this.RedactPractice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedactPractice.Name = "RedactPractice";
            this.RedactPractice.Size = new System.Drawing.Size(135, 51);
            this.RedactPractice.TabIndex = 0;
            this.RedactPractice.Text = "База практик";
            this.RedactPractice.UseVisualStyleBackColor = true;
            this.RedactPractice.Click += new System.EventHandler(this.RedactPractice_Click);
            // 
            // RedactTeachers
            // 
            this.RedactTeachers.Location = new System.Drawing.Point(32, 76);
            this.RedactTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedactTeachers.Name = "RedactTeachers";
            this.RedactTeachers.Size = new System.Drawing.Size(135, 51);
            this.RedactTeachers.TabIndex = 1;
            this.RedactTeachers.Text = "Преподаватели кафедры";
            this.RedactTeachers.UseVisualStyleBackColor = true;
            this.RedactTeachers.Click += new System.EventHandler(this.RedactTeachers_Click);
            // 
            // RedactStudents
            // 
            this.RedactStudents.Location = new System.Drawing.Point(32, 140);
            this.RedactStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedactStudents.Name = "RedactStudents";
            this.RedactStudents.Size = new System.Drawing.Size(135, 51);
            this.RedactStudents.TabIndex = 2;
            this.RedactStudents.Text = "Студенты кафедры";
            this.RedactStudents.UseVisualStyleBackColor = true;
            // 
            // RedactCompetence
            // 
            this.RedactCompetence.Location = new System.Drawing.Point(188, 16);
            this.RedactCompetence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedactCompetence.Name = "RedactCompetence";
            this.RedactCompetence.Size = new System.Drawing.Size(135, 51);
            this.RedactCompetence.TabIndex = 3;
            this.RedactCompetence.Text = "Компетенции";
            this.RedactCompetence.UseVisualStyleBackColor = true;
            this.RedactCompetence.Click += new System.EventHandler(this.RedactCompetence_Click);
            // 
            // ReductSchedule
            // 
            this.ReductSchedule.Location = new System.Drawing.Point(188, 76);
            this.ReductSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReductSchedule.Name = "ReductSchedule";
            this.ReductSchedule.Size = new System.Drawing.Size(135, 51);
            this.ReductSchedule.TabIndex = 4;
            this.ReductSchedule.Text = "Графики практик";
            this.ReductSchedule.UseVisualStyleBackColor = true;
            this.ReductSchedule.Click += new System.EventHandler(this.ReductSchedule_Click);
            // 
            // CreatePracticePlan
            // 
            this.CreatePracticePlan.Location = new System.Drawing.Point(339, 140);
            this.CreatePracticePlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatePracticePlan.Name = "CreatePracticePlan";
            this.CreatePracticePlan.Size = new System.Drawing.Size(135, 51);
            this.CreatePracticePlan.TabIndex = 5;
            this.CreatePracticePlan.Text = "Годовой план практик";
            this.CreatePracticePlan.UseVisualStyleBackColor = true;
            // 
            // CreateServiceNote
            // 
            this.CreateServiceNote.Location = new System.Drawing.Point(497, 16);
            this.CreateServiceNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateServiceNote.Name = "CreateServiceNote";
            this.CreateServiceNote.Size = new System.Drawing.Size(150, 51);
            this.CreateServiceNote.TabIndex = 6;
            this.CreateServiceNote.Text = "Формирование служебных записок";
            this.CreateServiceNote.UseVisualStyleBackColor = true;
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(497, 76);
            this.CreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(150, 51);
            this.CreateReport.TabIndex = 7;
            this.CreateReport.Text = "Годовой отчет по практикам";
            this.CreateReport.UseVisualStyleBackColor = true;
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(497, 140);
            this.DeleteData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(150, 51);
            this.DeleteData.TabIndex = 8;
            this.DeleteData.Text = "Удалить данные за период";
            this.DeleteData.UseVisualStyleBackColor = true;
            // 
            // GoToPracticeHead
            // 
            this.GoToPracticeHead.Location = new System.Drawing.Point(32, 251);
            this.GoToPracticeHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoToPracticeHead.Name = "GoToPracticeHead";
            this.GoToPracticeHead.Size = new System.Drawing.Size(615, 31);
            this.GoToPracticeHead.TabIndex = 9;
            this.GoToPracticeHead.Text = "Войти как руководитель практики";
            this.GoToPracticeHead.UseVisualStyleBackColor = true;
            this.GoToPracticeHead.Click += new System.EventHandler(this.GoToPracticeHead_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Направления подготовки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Профили";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Оценочные ведомости";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ResponsibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 308);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoToPracticeHead);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.CreateReport);
            this.Controls.Add(this.CreateServiceNote);
            this.Controls.Add(this.CreatePracticePlan);
            this.Controls.Add(this.ReductSchedule);
            this.Controls.Add(this.RedactCompetence);
            this.Controls.Add(this.RedactStudents);
            this.Controls.Add(this.RedactTeachers);
            this.Controls.Add(this.RedactPractice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResponsibleForm";
            this.Text = "Responsible";
            this.Load += new System.EventHandler(this.ResponsibleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RedactPractice;
        private System.Windows.Forms.Button RedactTeachers;
        private System.Windows.Forms.Button RedactStudents;
        private System.Windows.Forms.Button RedactCompetence;
        private System.Windows.Forms.Button ReductSchedule;
        private System.Windows.Forms.Button CreatePracticePlan;
        private System.Windows.Forms.Button CreateServiceNote;
        private System.Windows.Forms.Button CreateReport;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button GoToPracticeHead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}