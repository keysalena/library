using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HOV_Hospital
{
    public partial class FormAdd : Form
    {
        int id = 0;
        HospitalEntities ent = new HospitalEntities();
        public FormAdd(int selectId)
        {
            this.id = selectId;
            InitializeComponent();
        }
        public void SetTextBoxValue(string value)
        {
            textBox1.Text = value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id == 0) {
                patient_record pr_add = new patient_record
                {
                    patient_id = 0,
                    meeting_id = 0,
                    notes = textBox1.Text,
                };
                ent.patient_record.Add(pr_add);
                ent.SaveChanges();
            }
            else
            {
                patient_record pr = ent.patient_record.Where(d => d.id == this.id).FirstOrDefault();
                pr.notes = textBox1.Text;
                pr.last_updated_at = DateTime.Now;
                ent.SaveChanges();
                this.Close();
            }
        }
    }
}
