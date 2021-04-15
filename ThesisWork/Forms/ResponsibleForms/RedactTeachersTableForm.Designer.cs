
namespace ThesisWork.Forms.ResponsibleForms
{
    partial class RedactTeachersTableForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surname,
            this.Patronymic,
            this.FCs,
            this.Post,
            this.AcademicDegree,
            this.dataGridViewTextBoxColumn1,
            this.Rate,
            this.TelephoneNumber,
            this.TeacherTitle});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            // 
            // FCs
            // 
            this.FCs.HeaderText = "ФИО";
            this.FCs.MinimumWidth = 6;
            this.FCs.Name = "FCs";
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            // 
            // AcademicDegree
            // 
            this.AcademicDegree.HeaderText = "Учёная степень";
            this.AcademicDegree.MinimumWidth = 6;
            this.AcademicDegree.Name = "AcademicDegree";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Штатность";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Ставка";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.HeaderText = "Номер телефона";
            this.TelephoneNumber.MinimumWidth = 6;
            this.TelephoneNumber.Name = "TelephoneNumber";
            // 
            // TeacherTitle
            // 
            this.TeacherTitle.HeaderText = "Звание";
            this.TeacherTitle.MinimumWidth = 6;
            this.TeacherTitle.Name = "TeacherTitle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RedactTeachersTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            
            this.Text = "RedactTeachersTableForm";
            this.Load += new System.EventHandler(this.RedactTeachersTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherTitle;
        private System.Windows.Forms.Button button1;
    }
}