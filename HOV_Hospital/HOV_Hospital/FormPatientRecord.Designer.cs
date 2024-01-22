namespace HOV_Hospital
{
    partial class FormPatientRecord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medical Record of [Patient Name]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.DoctorCategory,
            this.DoctorName,
            this.Column2});
            this.dataGridView1.DataSource = this.patientrecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(643, 198);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // patientrecordBindingSource
            // 
            this.patientrecordBindingSource.DataSource = typeof(HOV_Hospital.patient_record);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DoctorCategory
            // 
            this.DoctorCategory.HeaderText = "Doctor Category";
            this.DoctorCategory.Name = "DoctorCategory";
            this.DoctorCategory.ReadOnly = true;
            // 
            // DoctorName
            // 
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "notes";
            this.Column2.HeaderText = "Record";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FormPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 349);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPatientRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Record";
            this.Load += new System.EventHandler(this.FormPatientRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientrecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}