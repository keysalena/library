namespace HOV_Hospital
{
    partial class FormMeeting
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditClm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteClm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.doctorCategory,
            this.doctorName,
            this.Column5,
            this.Pay});
            this.dataGridView1.DataSource = this.meetingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(694, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataSource = typeof(HOV_Hospital.meeting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Form Meeting";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add New Patient Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(28, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 197);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Records";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Record,
            this.id,
            this.EditClm,
            this.DeleteClm});
            this.dataGridView2.DataSource = this.patientrecordBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(682, 130);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // patientrecordBindingSource
            // 
            this.patientrecordBindingSource.DataSource = typeof(HOV_Hospital.patient_record);
            // 
            // Record
            // 
            this.Record.DataPropertyName = "notes";
            this.Record.HeaderText = "Record";
            this.Record.Name = "Record";
            this.Record.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // EditClm
            // 
            this.EditClm.HeaderText = "Edit";
            this.EditClm.Name = "EditClm";
            this.EditClm.ReadOnly = true;
            this.EditClm.Text = "Edit";
            this.EditClm.UseColumnTextForButtonValue = true;
            // 
            // DeleteClm
            // 
            this.DeleteClm.HeaderText = "Delete";
            this.DeleteClm.Name = "DeleteClm";
            this.DeleteClm.ReadOnly = true;
            this.DeleteClm.Text = "Delete";
            this.DeleteClm.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date";
            this.Column1.FillWeight = 86.83068F;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 129.3448F;
            this.name.HeaderText = "Patient Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // doctorCategory
            // 
            this.doctorCategory.FillWeight = 128.5131F;
            this.doctorCategory.HeaderText = "Doctor Category";
            this.doctorCategory.Name = "doctorCategory";
            this.doctorCategory.ReadOnly = true;
            // 
            // doctorName
            // 
            this.doctorName.FillWeight = 127.8498F;
            this.doctorName.HeaderText = "Doctor Name";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "queue_number";
            this.Column5.FillWeight = 45.47178F;
            this.Column5.HeaderText = "Queue";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Pay
            // 
            this.Pay.FillWeight = 81.9899F;
            this.Pay.HeaderText = "Payment";
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.Text = "Pay";
            this.Pay.UseColumnTextForButtonValue = true;
            // 
            // FormMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Meeting";
            this.Load += new System.EventHandler(this.FormMeeting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource meetingBindingSource;
        private System.Windows.Forms.BindingSource patientrecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn EditClm;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteClm;
    }
}