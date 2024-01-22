using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Department
{
    public partial class Form5 : Form
    {
        TASK1Entities entities = new TASK1Entities();
        bool isCreate = true;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        private void dataLoad()
        {
            var dep = entities.department.Where(d => d.deleted_at == null).ToList();
            departmentBindingSource.DataSource = dep;
            departmentBindingSource1.AddNew();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                label4.Text = "Please enter a value.";
                return;
            }
            if (departmentBindingSource1.Current is department depart)
            {
                if (isCreate)
                {
                    depart.created_at = DateTime.Now;
                }
                entities.department.AddOrUpdate(depart);
                entities.SaveChanges();
                dataLoad();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (departmentBindingSource.Current is department dep)
            {
                if (e.ColumnIndex == deleteColoum.Index)
                {
                    dep.deleted_at = DateTime.Now;
                    entities.SaveChanges();

                    dataLoad();
                }
                if (e.ColumnIndex == editColoum.Index)
                {
                    departmentBindingSource1.DataSource = entities.department.AsNoTracking().FirstOrDefault(a => a.id == dep.id);
                }
            }
        }
    }
}
