
namespace ThesisWork.Forms.ResponsibleForms
{
    partial class RedactCompetenceTableForm
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
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Qualification,
            this.Description,
            this.Vector,
            this.ProfileName});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Квалификация";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Vector
            // 
            this.Vector.HeaderText = "Номер направления подготовки";
            this.Vector.MinimumWidth = 6;
            this.Vector.Name = "Vector";
            // 
            // ProfileName
            // 
            this.ProfileName.HeaderText = "Название профиля";
            this.ProfileName.MinimumWidth = 6;
            this.ProfileName.Name = "ProfileName";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RedactCompetenceTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RedactCompetenceTableForm";
            this.Text = "RedactCompetenceTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vector;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.Button button1;
    }
}