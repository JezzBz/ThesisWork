
namespace ThesisWork.Forms.ResponsibleForms
{
    partial class RedactPracticeTableForm
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
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadOfCompanyPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadOfCompanyFCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsiblePost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsibleFCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.Index,
            this.Region,
            this.City,
            this.Street,
            this.Building,
            this.DocumentNumber,
            this.HeadOfCompanyPost,
            this.HeadOfCompanyFCs,
            this.ResponsiblePost,
            this.ResponsibleFCs});
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1427, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Название Компании";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 125;
            // 
            // Index
            // 
            this.Index.HeaderText = "Индекс";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 125;
            // 
            // Region
            // 
            this.Region.HeaderText = "Регион";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // Street
            // 
            this.Street.HeaderText = "Улица";
            this.Street.MinimumWidth = 6;
            this.Street.Name = "Street";
            this.Street.Width = 125;
            // 
            // Building
            // 
            this.Building.HeaderText = "Дом";
            this.Building.MinimumWidth = 6;
            this.Building.Name = "Building";
            this.Building.Width = 125;
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.HeaderText = "Номер договора";
            this.DocumentNumber.MinimumWidth = 6;
            this.DocumentNumber.Name = "DocumentNumber";
            this.DocumentNumber.Width = 125;
            // 
            // HeadOfCompanyPost
            // 
            this.HeadOfCompanyPost.HeaderText = "Должность руководителя предприятия";
            this.HeadOfCompanyPost.MinimumWidth = 6;
            this.HeadOfCompanyPost.Name = "HeadOfCompanyPost";
            this.HeadOfCompanyPost.Width = 125;
            // 
            // HeadOfCompanyFCs
            // 
            this.HeadOfCompanyFCs.HeaderText = "ФИО руководителя предприятия";
            this.HeadOfCompanyFCs.MinimumWidth = 6;
            this.HeadOfCompanyFCs.Name = "HeadOfCompanyFCs";
            this.HeadOfCompanyFCs.Width = 125;
            // 
            // ResponsiblePost
            // 
            this.ResponsiblePost.HeaderText = "Должность ответственного лица";
            this.ResponsiblePost.MinimumWidth = 6;
            this.ResponsiblePost.Name = "ResponsiblePost";
            this.ResponsiblePost.Width = 125;
            // 
            // ResponsibleFCs
            // 
            this.ResponsibleFCs.HeaderText = "ФИО ответсвтенного лица";
            this.ResponsibleFCs.MinimumWidth = 6;
            this.ResponsibleFCs.Name = "ResponsibleFCs";
            this.ResponsibleFCs.Width = 125;
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
            // RedactPracticeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RedactPracticeTableForm";
            this.Text = "RedactPracticeTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Building;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadOfCompanyPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadOfCompanyFCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsiblePost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsibleFCs;
        private System.Windows.Forms.Button button1;
    }
}