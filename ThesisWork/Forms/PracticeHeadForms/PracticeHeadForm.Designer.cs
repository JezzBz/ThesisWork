
namespace ThesisWork.Forms
{
    partial class PracticeHeadForm
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
            this.PracticeSchedule = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticeHourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticePlan = new System.Windows.Forms.Button();
            this.StudentsPattern = new System.Windows.Forms.Button();
            this.Statement = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PracticeSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // PracticeSchedule
            // 
            this.PracticeSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PracticeSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PracticeSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PracticeSchedule.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.PracticeSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PracticeSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.StudentsNumber,
            this.Vector,
            this.Weeks,
            this.PracticeHourse,
            this.ExamenHours,
            this.Dates});
            this.PracticeSchedule.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.PracticeSchedule.Location = new System.Drawing.Point(-2, 233);
            this.PracticeSchedule.Name = "PracticeSchedule";
            this.PracticeSchedule.RowHeadersWidth = 51;
            this.PracticeSchedule.RowTemplate.Height = 29;
            this.PracticeSchedule.Size = new System.Drawing.Size(1265, 428);
            this.PracticeSchedule.TabIndex = 0;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // StudentsNumber
            // 
            this.StudentsNumber.HeaderText = "Количество студентов";
            this.StudentsNumber.MinimumWidth = 6;
            this.StudentsNumber.Name = "StudentsNumber";
            this.StudentsNumber.ReadOnly = true;
            // 
            // Vector
            // 
            this.Vector.HeaderText = "Направление";
            this.Vector.MinimumWidth = 6;
            this.Vector.Name = "Vector";
            this.Vector.ReadOnly = true;
            // 
            // Weeks
            // 
            this.Weeks.HeaderText = "Количество недель";
            this.Weeks.MinimumWidth = 6;
            this.Weeks.Name = "Weeks";
            this.Weeks.ReadOnly = true;
            // 
            // PracticeHourse
            // 
            this.PracticeHourse.HeaderText = "Часы на практику";
            this.PracticeHourse.MinimumWidth = 6;
            this.PracticeHourse.Name = "PracticeHourse";
            this.PracticeHourse.ReadOnly = true;
            // 
            // ExamenHours
            // 
            this.ExamenHours.HeaderText = "Часы на зачёт";
            this.ExamenHours.MinimumWidth = 6;
            this.ExamenHours.Name = "ExamenHours";
            this.ExamenHours.ReadOnly = true;
            // 
            // Dates
            // 
            this.Dates.HeaderText = "Срок прохождения";
            this.Dates.MinimumWidth = 6;
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            // 
            // PracticePlan
            // 
            this.PracticePlan.Location = new System.Drawing.Point(45, 50);
            this.PracticePlan.Name = "PracticePlan";
            this.PracticePlan.Size = new System.Drawing.Size(187, 39);
            this.PracticePlan.TabIndex = 1;
            this.PracticePlan.Text = "План практики";
            this.PracticePlan.UseVisualStyleBackColor = true;
            // 
            // StudentsPattern
            // 
            this.StudentsPattern.Location = new System.Drawing.Point(45, 108);
            this.StudentsPattern.Name = "StudentsPattern";
            this.StudentsPattern.Size = new System.Drawing.Size(187, 39);
            this.StudentsPattern.TabIndex = 2;
            this.StudentsPattern.Text = "Шаблон для студентов";
            this.StudentsPattern.UseVisualStyleBackColor = true;
            // 
            // Statement
            // 
            this.Statement.Location = new System.Drawing.Point(256, 50);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(187, 39);
            this.Statement.TabIndex = 3;
            this.Statement.Text = "Ведомость";
            this.Statement.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(256, 108);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(187, 39);
            this.Report.TabIndex = 4;
            this.Report.Text = "Отчёт";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // PracticeHeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.StudentsPattern);
            this.Controls.Add(this.PracticePlan);
            this.Controls.Add(this.PracticeSchedule);
            this.Name = "PracticeHeadForm";
            this.Text = "PracticeHeadForm";
            this.Load += new System.EventHandler(this.PracticeHeadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PracticeSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PracticeSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticeHourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.Button PracticePlan;
        private System.Windows.Forms.Button StudentsPattern;
        private System.Windows.Forms.Button Statement;
        private System.Windows.Forms.Button Report;
    }
}