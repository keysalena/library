using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class Form1 : Form
    {
        TASK1Entities ent = new TASK1Entities();
        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var departments = ent.department.Where(q => q.deleted_at == null).ToList();
            departmentBindingSource.DataSource = departments;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonSave();
        }

        private void buttonSave()
        {
            textBox1.Clear();
            textBox2.Clear();
            id = 0;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == editColoum.Index && e.RowIndex >= 0)
            {
                int clickedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_coloum"].Value.ToString());
                if (clickedId > 0)
                {
                    this.id = clickedId;
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["nameColoum"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["abbreviationColoum"].Value.ToString();
                }
            }
            if (e.ColumnIndex == deleteColoum.Index && e.RowIndex >= 0)
            {
                int clickedId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_coloum"].Value.ToString());
                department dep = ent.department.FirstOrDefault(d => d.id == clickedId);

                if (dep != null)
                {
                    dep.name = dataGridView1.Rows[e.RowIndex].Cells["nameColoum"].Value.ToString();
                    dep.abbreviation = dataGridView1.Rows[e.RowIndex].Cells["abbreviationColoum"].Value.ToString();
                    dep.deleted_at = DateTime.Now;
                    ent.SaveChanges();

                    LoadData();
                    buttonSave();
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    label4.Text = "Please enter a value.";
                    return;
                }
                    if (this.id == 0)
                    {
                        department dep = new department
                        {
                            created_at = DateTime.Now,
                            name = textBox1.Text,
                            abbreviation = textBox2.Text,
                        };
                        ent.department.Add(dep);

                        ent.SaveChanges();

                        LoadData();
                        buttonSave();
                    }
                    else
                    {
                        department dep = ent.department.Where(d => d.id == this.id).First();
                        dep.name = textBox1.Text;
                        dep.abbreviation = textBox2.Text;

                        ent.SaveChanges();

                        LoadData();
                        buttonSave();
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }          
}
