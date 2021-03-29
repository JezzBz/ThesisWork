
namespace ThesisWork.Forms.ResponsibleForms
{
    partial class RedactScheduleTableForm
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
            this.ChangeTable = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticeHourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PracticeSchedule.Location = new System.Drawing.Point(1, 89);
            this.PracticeSchedule.Name = "PracticeSchedule";
            this.PracticeSchedule.RowHeadersWidth = 51;
            this.PracticeSchedule.RowTemplate.Height = 29;
            this.PracticeSchedule.Size = new System.Drawing.Size(1312, 449);
            this.PracticeSchedule.TabIndex = 1;
            // 
            // ChangeTable
            // 
            this.ChangeTable.Location = new System.Drawing.Point(545, 12);
            this.ChangeTable.Name = "ChangeTable";
            this.ChangeTable.Size = new System.Drawing.Size(225, 29);
            this.ChangeTable.TabIndex = 2;
            this.ChangeTable.Text = "Применить изменения";
            this.ChangeTable.UseVisualStyleBackColor = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            // 
            // StudentsNumber
            // 
            this.StudentsNumber.HeaderText = "Количество студентов";
            this.StudentsNumber.MinimumWidth = 6;
            this.StudentsNumber.Name = "StudentsNumber";
            // 
            // Vector
            // 
            this.Vector.HeaderText = "Направление";
            this.Vector.MinimumWidth = 6;
            this.Vector.Name = "Vector";
            // 
            // Weeks
            // 
            this.Weeks.HeaderText = "Количество недель";
            this.Weeks.MinimumWidth = 6;
            this.Weeks.Name = "Weeks";
            // 
            // PracticeHourse
            // 
            this.PracticeHourse.HeaderText = "Часы на практику";
            this.PracticeHourse.MinimumWidth = 6;
            this.PracticeHourse.Name = "PracticeHourse";
            // 
            // ExamenHours
            // 
            this.ExamenHours.HeaderText = "Часы на зачёт";
            this.ExamenHours.MinimumWidth = 6;
            this.ExamenHours.Name = "ExamenHours";
            // 
            // Dates
            // 
            this.Dates.HeaderText = "Срок прохождения";
            this.Dates.MinimumWidth = 6;
            this.Dates.Name = "Dates";
            // 
            // RedactScheduleTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 541);
            this.Controls.Add(this.ChangeTable);
            this.Controls.Add(this.PracticeSchedule);
            this.Name = "RedactScheduleTableForm";
            this.Text = "RedactPracticeTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.PracticeSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PracticeSchedule;
        private System.Windows.Forms.Button ChangeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticeHourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
    }
}