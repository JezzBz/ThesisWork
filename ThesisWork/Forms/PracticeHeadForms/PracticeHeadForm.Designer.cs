
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
            this.practiceSchedule = new System.Windows.Forms.DataGridView();
            this.PracticePlan = new System.Windows.Forms.Button();
            this.StudentsPattern = new System.Windows.Forms.Button();
            this.Statement = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.practiceSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // practiceSchedule
            // 
            this.practiceSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.practiceSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.practiceSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.practiceSchedule.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.practiceSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.practiceSchedule.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.practiceSchedule.Location = new System.Drawing.Point(374, 233);
            this.practiceSchedule.Name = "practiceSchedule";
            this.practiceSchedule.RowHeadersWidth = 51;
            this.practiceSchedule.RowTemplate.Height = 29;
            this.practiceSchedule.Size = new System.Drawing.Size(888, 428);
            this.practiceSchedule.TabIndex = 0;
            this.practiceSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PracticeSchedule_CellContentClick);
            // 
            // PracticePlan
            // 
            this.PracticePlan.Location = new System.Drawing.Point(56, 51);
            this.PracticePlan.Name = "PracticePlan";
            this.PracticePlan.Size = new System.Drawing.Size(155, 52);
            this.PracticePlan.TabIndex = 1;
            this.PracticePlan.Text = "План уч. нагрузки по практикам";
            this.PracticePlan.UseVisualStyleBackColor = true;
            // 
            // StudentsPattern
            // 
            this.StudentsPattern.Location = new System.Drawing.Point(56, 121);
            this.StudentsPattern.Name = "StudentsPattern";
            this.StudentsPattern.Size = new System.Drawing.Size(155, 56);
            this.StudentsPattern.TabIndex = 2;
            this.StudentsPattern.Text = "Шаблоны отчетов для студентов";
            this.StudentsPattern.UseVisualStyleBackColor = true;
            this.StudentsPattern.Click += new System.EventHandler(this.StudentsPattern_Click);
            // 
            // Statement
            // 
            this.Statement.Location = new System.Drawing.Point(241, 51);
            this.Statement.Name = "Statement";
            this.Statement.Size = new System.Drawing.Size(155, 52);
            this.Statement.TabIndex = 3;
            this.Statement.Text = "Оценочные ведомости";
            this.Statement.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(241, 121);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(155, 56);
            this.Report.TabIndex = 4;
            this.Report.Text = "Отчёт руководителя практики";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(1, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(377, 428);
            this.dataGridView1.TabIndex = 6;
            // 
            // PracticeHeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.StudentsPattern);
            this.Controls.Add(this.PracticePlan);
            this.Controls.Add(this.practiceSchedule);
            this.Name = "PracticeHeadForm";
            this.Text = "д.";
            this.Load += new System.EventHandler(this.PracticeHeadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.practiceSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView practiceSchedule;
        private System.Windows.Forms.Button PracticePlan;
        private System.Windows.Forms.Button StudentsPattern;
        private System.Windows.Forms.Button Statement;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}