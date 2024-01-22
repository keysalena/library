using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaHero
{
    public partial class FormHeroo : Form
    {
        EsemkaHeroEntities entities = new EsemkaHeroEntities();
        public FormHeroo()
        {
            InitializeComponent();
        }

        private void FormHeroo_Load(object sender, EventArgs e)
        {
            var hero = entities.Hero.ToList();
            heroBindingSource.DataSource = hero;
        }
    }
}
