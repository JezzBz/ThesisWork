
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
            this.textFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.PracticeSchedule.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.PracticeSchedule.Location = new System.Drawing.Point(1, 154);
            this.PracticeSchedule.Name = "PracticeSchedule";
            this.PracticeSchedule.RowHeadersWidth = 51;
            this.PracticeSchedule.RowTemplate.Height = 29;
            this.PracticeSchedule.Size = new System.Drawing.Size(1312, 387);
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
            this.ChangeTable.Click += new System.EventHandler(this.ChangeTable_Click);
            // 
            // textFileName
            // 
            this.textFileName.Enabled = false;
            this.textFileName.Location = new System.Drawing.Point(29, 83);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(344, 27);
            this.textFileName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RedactScheduleTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.ChangeTable);
            this.Controls.Add(this.PracticeSchedule);
            this.Name = "RedactScheduleTableForm";
            this.Text = "Редактирование расписания";
            this.Load += new System.EventHandler(this.RedactScheduleTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PracticeSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PracticeSchedule;
        private System.Windows.Forms.Button ChangeTable;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button button1;
    }
}