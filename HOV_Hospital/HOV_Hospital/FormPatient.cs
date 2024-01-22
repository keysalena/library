using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOV_Hospital
{
    public partial class FormPatient : Form
    {
        public string SelectedPatientName { get; private set; }

        HospitalEntities ent = new HospitalEntities();

        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var filteredPatients = ent.patient
                .Where(p => p.deleted_at == null && p.name.Contains(textBox1.Text))
                .ToList();
            patientBindingSource.DataSource = filteredPatients;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is patient pt)
            {
                textBox5.Text = $"{pt.city_of_birth}, {pt.date_of_birth.ToString("dd/MM/yyyy")}";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells["name"].Value;

                SelectedPatientName = cellValue?.ToString();

                this.Close();
            }
        }
    }
}


