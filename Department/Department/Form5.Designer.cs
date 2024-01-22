namespace Department
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_coloum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColoum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviationColoum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColoum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColoum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_coloum,
            this.nameColoum,
            this.abbreviationColoum,
            this.editColoum,
            this.deleteColoum});
            this.dataGridView1.DataSource = this.departmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(414, 203);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_coloum
            // 
            this.id_coloum.DataPropertyName = "id";
            this.id_coloum.HeaderText = "id";
            this.id_coloum.Name = "id_coloum";
            this.id_coloum.ReadOnly = true;
            this.id_coloum.Visible = false;
            // 
            // nameColoum
            // 
            this.nameColoum.DataPropertyName = "name";
            this.nameColoum.HeaderText = "Name";
            this.nameColoum.Name = "nameColoum";
            this.nameColoum.ReadOnly = true;
            // 
            // abbreviationColoum
            // 
            this.abbreviationColoum.DataPropertyName = "abbreviation";
            this.abbreviationColoum.HeaderText = "Abbreviation";
            this.abbreviationColoum.Name = "abbreviationColoum";
            this.abbreviationColoum.ReadOnly = true;
            // 
            // editColoum
            // 
            this.editColoum.HeaderText = "";
            this.editColoum.Name = "editColoum";
            this.editColoum.ReadOnly = true;
            this.editColoum.Text = "Edit";
            this.editColoum.UseColumnTextForButtonValue = true;
            // 
            // deleteColoum
            // 
            this.deleteColoum.HeaderText = " ";
            this.deleteColoum.Name = "deleteColoum";
            this.deleteColoum.ReadOnly = true;
            this.deleteColoum.Text = "Delete";
            this.deleteColoum.UseColumnTextForButtonValue = true;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Department.department);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(100, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 25;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource1, "abbreviation", true));
            this.textBox2.Location = new System.Drawing.Point(100, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 21;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(Department.department);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource1, "name", true));
            this.textBox1.Location = new System.Drawing.Point(100, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Abbreviation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "DEPARTMENT";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_coloum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColoum;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviationColoum;
        private System.Windows.Forms.DataGridViewButtonColumn editColoum;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColoum;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
    }
}