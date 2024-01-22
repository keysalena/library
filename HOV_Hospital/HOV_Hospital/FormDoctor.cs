using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOV_Hospital
{
    public partial class FormDoctor : Form
    {
        public string SelectedDoctorName { get; set; }
        HospitalEntities ent = new HospitalEntities();
        public FormDoctor()
        {
            InitializeComponent();
        }
        private void FormDoctor_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            textBox1.Text = SelectedDoctorName;
            ApplyFilter();
        }
        private void LoadComboBox()
        {
            comboBox1.Items.Clear();
            var categories = ent.doctor_category.ToList();
            foreach (var category in categories)
            {
                comboBox1.Items.Add(category.category);
            }
        }
        private void ApplyFilter()
        {
            var selectedCategory = comboBox1.SelectedItem?.ToString();

            var filteredDoctors = ent.doctor
                .Where(d => d.deleted_at == null &&
                            (selectedCategory == null || d.doctor_category.category == selectedCategory) &&
                            d.name.Contains(textBox1.Text))
                .ToList();

            doctorBindingSource.DataSource = filteredDoctors;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is doctor dr)
            {
                if (e.ColumnIndex == categoryClm.Index)
                {
                    e.Value = dr.doctor_category.category;
                }
            }
        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is doctor selectedDoctor)
            {
                textBox9.Text = selectedDoctor.doctor_category.category;
                textBox5.Text = $"{selectedDoctor.city_of_birth}, {selectedDoctor.date_of_birth.ToString("dd/MM/yyyy")}";
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedItem = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells["nameClm"].Value;

                SelectedDoctorName = cellValue?.ToString();

                this.Close();
            }
        }
    }
}
