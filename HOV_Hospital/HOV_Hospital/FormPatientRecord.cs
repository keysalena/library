using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HOV_Hospital
{
    public partial class FormPatientRecord : Form
    {
        HospitalEntities ent = new HospitalEntities();
        public string PatientName { get; set; }

        public FormPatientRecord()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPatientRecord_Load(object sender, EventArgs e)
        {
            label1.Text = $"Medical Record of {PatientName}";
            patientrecordBindingSource.DataSource = ent.patient_record.Where(o => o.deleted_at == null && o.patient.name == PatientName).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is patient_record pr)
            {
                if (e.ColumnIndex == DoctorCategory.Index)
                {
                    e.Value = pr.meeting.doctor.doctor_category.category;
                }
                if (e.ColumnIndex == DoctorName.Index)
                {
                    e.Value = pr.meeting.doctor.name;
                }
            }
        }
    }
}
