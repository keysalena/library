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
    public partial class FormICD_11 : Form
    {
        private int selectedIcdId;

        HospitalEntities ent = new HospitalEntities();
        public FormICD_11()
        {
            InitializeComponent();
        }
        private void ApplyFilter()
        {
            if (comboBox1.SelectedItem != null)
            {
                var selectedIcdPair = (KeyValuePair<int, string>)comboBox1.SelectedItem;

                var filterICD = ent.icd_11
                    .Where(d => d.id == selectedIcdPair.Key)
                    .FirstOrDefault();

                icd11BindingSource.DataSource = filterICD;
                selectedIcdId = filterICD.id;
                PopulateListView();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void FormICD_11_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            ApplyFilter();
            PopulateListView();
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            linkLabel1.Text = string.Empty;
            linkLabel2.Text = string.Empty;
        }
        private void ComboBoxLoad()
        {
            comboBox1.Items.Clear();
            var icds = ent.icd_11.ToList();

            foreach (var icd in icds)
            {
                comboBox1.Items.Add(new KeyValuePair<int, string>(icd.id, icd.name));
            }
        }
        private void PopulateListView()
        {
            listView1.Items.Clear();

            var selectedIcdExclusions = ent.icd_11_exclusion
                .Where(d => d.icd_11_id == selectedIcdId)
                .ToList();

            foreach (var exclusion in selectedIcdExclusions)
            {
                ListViewItem item = new ListViewItem(new string[] { exclusion.exclusion.ToString(), exclusion.exclusion });
                listView1.Items.Add(item);
            }

            var sc = ent.icd_11_doctor_recommendation
                .Where(d => d.icd_11_id == selectedIcdId)
                .FirstOrDefault();

            if (sc != null)
            {
                label4.Text = sc.doctor_category.category;
                label3.Text = sc.doctor_category.category;

                var doctorsWithSameCategory = ent.doctor
                    .Where(d => d.doctor_category_id == sc.doctor_category_id)
                    .ToList();

                if (doctorsWithSameCategory.Count >= 2)
                {
                    linkLabel1.Text = doctorsWithSameCategory[0].name;
                    linkLabel2.Text = doctorsWithSameCategory[1].name;
                }
                else if (doctorsWithSameCategory.Count == 1)
                {
                    linkLabel1.Text = doctorsWithSameCategory[0].name;
                    label3.Text = string.Empty;
                    linkLabel2.Text = string.Empty;
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDoctor fd = new FormDoctor();
            fd.SelectedDoctorName = linkLabel1.Text;
            fd.ShowDialog();
            ApplyFilter();
            PopulateListView();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDoctor fd = new FormDoctor();
            fd.SelectedDoctorName = linkLabel2.Text;
            fd.ShowDialog();
            ApplyFilter();
            PopulateListView();
        }
    }
}
