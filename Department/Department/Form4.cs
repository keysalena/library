using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class Form4 : Form
    {
        bool iscreated = false;
        TASK1Entities entities = new TASK1Entities();
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var departments = entities.department.Where(q => q.deleted_at == null).ToList();
            departmentBindingSource.DataSource = departments;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (departmentBindingSource.Current is department dep)
            {
                if (iscreated)
                {                    
                dep.created_at = DateTime.Now;
                }
                entities.department.AddOrUpdate(dep);
                entities.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (departmentBindingSource.Current is department dep)
            {
                dep.deleted_at = DateTime.Now;
                entities.SaveChanges();
            }
        }
        private void departmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(departmentBindingSource.Position.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            departmentBindingSource.AddNew();
            iscreated = true;
        }
    }
}
