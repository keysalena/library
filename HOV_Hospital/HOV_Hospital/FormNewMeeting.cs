using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace HOV_Hospital
{
    public partial class FormNewMeeting : Form
    {
        HospitalEntities ent = new HospitalEntities();
        public FormNewMeeting()
        {
            InitializeComponent();
            LoadComboBox();
            ApplyFilter();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPatient fp = new FormPatient();
            fp.ShowDialog();

            string selectedPatientName = fp.SelectedPatientName;

            textBox1.Text = selectedPatientName;
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
        private void UpdateLabel6()
        {
            string id_patient = textBox1.Text;
            string id_doctor = comboBox2.Text;

            var doctor = ent.doctor.FirstOrDefault(t => t.name == id_doctor);
            var patient = ent.patient.FirstOrDefault(p => p.name == id_patient);

            DateTime selectedDate = dateTimePicker1.Value;

            int maxQueueNumber = ent.meeting
                 .Where(m => m.doctor_id == doctor.id &&
                 DbFunctions.TruncateTime(m.date) == DbFunctions.TruncateTime(selectedDate))
                 .Select(m => m.queue_number)
                 .DefaultIfEmpty(0)
                 .Max();

            int nextQueueNumber = maxQueueNumber + 1;

            label6.Text = nextQueueNumber.ToString();
        }
        private void ApplyFilter()
        {
            comboBox2.Items.Clear();

            var selectedCategory = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var selectedCategoryId = ent.doctor_category
                    .Where(c => c.category == selectedCategory)
                    .Select(c => c.id)
                    .FirstOrDefault();

                var filteredDoctors = ent.doctor
                    .Where(d => d.doctor_category_id == selectedCategoryId)
                    .ToList();

                foreach (var doctors in filteredDoctors)
                {
                    comboBox2.Items.Add(doctors.name);
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDoctor fp = new FormDoctor();
            fp.ShowDialog();

            string selectedDoctorName = fp.SelectedDoctorName;
            var doctor = ent.doctor.FirstOrDefault(d => d.name == selectedDoctorName);

            comboBox1.Text = selectedDoctorName;
            comboBox2.Text = doctor.doctor_category.category;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_patient = textBox1.Text;
            string id_doctor = comboBox2.Text;

            var doctor = ent.doctor.FirstOrDefault(t => t.name == id_doctor);
            var patient = ent.patient.FirstOrDefault(p => p.name == id_patient);

            DateTime selectedDate = dateTimePicker1.Value;

            int maxQueueNumber = ent.meeting
                 .Where(m => m.doctor_id == doctor.id &&
                 DbFunctions.TruncateTime(m.date) == DbFunctions.TruncateTime(selectedDate))
                 .Select(m => m.queue_number)
                 .DefaultIfEmpty(0)
                 .Max();

            int nextQueueNumber = maxQueueNumber + 1;

            meeting mw = new meeting
            {
                patient_id = patient.id,
                doctor_id = doctor.id,
                room = doctor.assigned_room,
                date = selectedDate,
                queue_number = nextQueueNumber,
                created_at = DateTime.Now,
            };

            ent.meeting.Add(mw);
            ent.SaveChanges();
            this.Close();
            FormMeeting idc = new FormMeeting();
            idc.MdiParent = FormMain.ActiveForm;
            idc.Show();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPatientRecord fd = new FormPatientRecord();
            fd.PatientName = textBox1.Text;
            fd.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel6();
        }
    }
}
