using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOV_Hospital
{
    public partial class FormMeeting : Form
    {
        HospitalEntities ent = new HospitalEntities();
        int selectId = 0;
        public FormMeeting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd(selectId);
            form.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Pay.Index && e.RowIndex >= 0)
            {
                FormPayment form = new FormPayment();
                form.ShowDialog();
            }
        }

        private void FormMeeting_Load(object sender, EventArgs e)
        {
            dataLoad();
        }

        public void dataLoad()
        {
            dataGridView2.Columns[0].Width = 550;
            meetingBindingSource.DataSource = ent.meeting.Where(o => o.deleted_at == null).ToList();
            patientrecordBindingSource.DataSource = ent.patient_record.Where(l => l.deleted_at == null).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is meeting meeting)
                {
                    if (e.ColumnIndex == doctorCategory.Index)
                    {
                        e.Value = meeting.doctor?.doctor_category?.category;
                    }
                    else if (e.ColumnIndex == doctorName.Index)
                    {
                        e.Value = meeting.doctor?.name;
                    }
                    else if (e.ColumnIndex == name.Index)
                    {
                        e.Value = meeting.patient?.name;
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (patientrecordBindingSource.Current is patient_record patient_Record)
            {
                {
                    if (e.ColumnIndex == DeleteClm.Index)
                    {
                        patient_Record.deleted_at = DateTime.Now;
                        ent.SaveChanges();

                        dataLoad();
                    }
                    if (e.ColumnIndex == EditClm.Index)
                    {
                        int selectId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id"].Value);

                        patient_record selectedPatientRecord = ent.patient_record.AsNoTracking().FirstOrDefault(a => a.id == selectId);

                        if (selectedPatientRecord != null)
                        {
                            FormAdd form = new FormAdd(selectId);

                            form.SetTextBoxValue(selectedPatientRecord.notes);

                            form.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
