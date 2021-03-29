
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
            this.SuspendLayout();
            // 
            // RedactPractice
            // 
            this.RedactPractice.Location = new System.Drawing.Point(37, 21);
            this.RedactPractice.Name = "RedactPractice";
            this.RedactPractice.Size = new System.Drawing.Size(154, 68);
            this.RedactPractice.TabIndex = 0;
            this.RedactPractice.Text = "Редактировать таблицу практик";
            this.RedactPractice.UseVisualStyleBackColor = true;
            this.RedactPractice.Click += new System.EventHandler(this.RedactPractice_Click);
            // 
            // RedactTeachers
            // 
            this.RedactTeachers.Location = new System.Drawing.Point(37, 101);
            this.RedactTeachers.Name = "RedactTeachers";
            this.RedactTeachers.Size = new System.Drawing.Size(154, 68);
            this.RedactTeachers.TabIndex = 1;
            this.RedactTeachers.Text = "Редактировать таблицу преподавателей";
            this.RedactTeachers.UseVisualStyleBackColor = true;
            // 
            // RedactStudents
            // 
            this.RedactStudents.Location = new System.Drawing.Point(37, 186);
            this.RedactStudents.Name = "RedactStudents";
            this.RedactStudents.Size = new System.Drawing.Size(154, 68);
            this.RedactStudents.TabIndex = 2;
            this.RedactStudents.Text = "Редактировать таблицу студентов";
            this.RedactStudents.UseVisualStyleBackColor = true;
            // 
            // RedactCompetence
            // 
            this.RedactCompetence.Location = new System.Drawing.Point(215, 21);
            this.RedactCompetence.Name = "RedactCompetence";
            this.RedactCompetence.Size = new System.Drawing.Size(154, 68);
            this.RedactCompetence.TabIndex = 3;
            this.RedactCompetence.Text = "Редактировать таблицу компетенций";
            this.RedactCompetence.UseVisualStyleBackColor = true;
            this.RedactCompetence.Click += new System.EventHandler(this.RedactCompetence_Click);
            // 
            // ReductSchedule
            // 
            this.ReductSchedule.Location = new System.Drawing.Point(215, 101);
            this.ReductSchedule.Name = "ReductSchedule";
            this.ReductSchedule.Size = new System.Drawing.Size(154, 68);
            this.ReductSchedule.TabIndex = 4;
            this.ReductSchedule.Text = "Редактировать таблицу графиков";
            this.ReductSchedule.UseVisualStyleBackColor = true;
            this.ReductSchedule.Click += new System.EventHandler(this.ReductSchedule_Click);
            // 
            // CreatePracticePlan
            // 
            this.CreatePracticePlan.Location = new System.Drawing.Point(215, 186);
            this.CreatePracticePlan.Name = "CreatePracticePlan";
            this.CreatePracticePlan.Size = new System.Drawing.Size(154, 68);
            this.CreatePracticePlan.TabIndex = 5;
            this.CreatePracticePlan.Text = "Сформировать план практик";
            this.CreatePracticePlan.UseVisualStyleBackColor = true;
            // 
            // CreateServiceNote
            // 
            this.CreateServiceNote.Location = new System.Drawing.Point(395, 21);
            this.CreateServiceNote.Name = "CreateServiceNote";
            this.CreateServiceNote.Size = new System.Drawing.Size(172, 68);
            this.CreateServiceNote.TabIndex = 6;
            this.CreateServiceNote.Text = "Сформировать служебные записки";
            this.CreateServiceNote.UseVisualStyleBackColor = true;
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(395, 101);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(172, 68);
            this.CreateReport.TabIndex = 7;
            this.CreateReport.Text = "Сформировать отчёт ответственного за практику ";
            this.CreateReport.UseVisualStyleBackColor = true;
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(395, 186);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(172, 68);
            this.DeleteData.TabIndex = 8;
            this.DeleteData.Text = "Удалить данные за период";
            this.DeleteData.UseVisualStyleBackColor = true;
            // 
            // GoToPracticeHead
            // 
            this.GoToPracticeHead.Location = new System.Drawing.Point(75, 305);
            this.GoToPracticeHead.Name = "GoToPracticeHead";
            this.GoToPracticeHead.Size = new System.Drawing.Size(432, 41);
            this.GoToPracticeHead.TabIndex = 9;
            this.GoToPracticeHead.Text = "Войти как руководитель практики";
            this.GoToPracticeHead.UseVisualStyleBackColor = true;
            this.GoToPracticeHead.Click += new System.EventHandler(this.GoToPracticeHead_Click);
            // 
            // ResponsibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 410);
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
    }
}