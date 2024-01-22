using System;
using System.Windows.Forms;

namespace Department
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.TextChanged += TxtSource_TextChanged;
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}