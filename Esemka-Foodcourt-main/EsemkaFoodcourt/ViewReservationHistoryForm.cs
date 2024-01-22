using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaFoodcourt
{
    public partial class ViewReservationHistoryForm : Form
    {
        private EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();

        public ViewReservationHistoryForm()
        {
            InitializeComponent();
        }

        private void ViewReservationHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new UserMainForm().Show();
        }

        private void ViewReservationHistoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var query = db.Reservations.Where(x => x.UserID == GlobalData.User.ID).ToList();

            dgvHistory.Columns.Clear();

            dgvHistory.DataSource = query.Select(x => new
            {
                x.ID,
                x.ReservationDate,
                TableNo = x.Tables.Name,
                x.NumberOfPeople,
                TotalPrice = $"Rp{(x.ReservationDetails.Sum(y => y.Menus.Price * y.Qty) + GlobalData.ReservationFee).ToString("N2")}"
            }).ToList();

            dgvHistory.Columns["ID"].Visible = false;

            dgvHistory.ClearSelection();
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                dgvMenu.Columns.Clear();

                var reservationID = int.Parse(dgvHistory["ID", e.RowIndex].Value.ToString());
                var query = db.ReservationDetails.Where(x => x.ReservationID == reservationID).ToList();

                dgvMenu.DataSource = query.Select(x => new
                {
                    Menu = x.Menus.Name,
                    x.Qty,
                    Price = $"Rp{x.Menus.Price.ToString("N2")}",
                    Subtotal = $"Rp{(x.Qty * x.Menus.Price).ToString("N2")}"
                }).ToList();
            }
        }
    }
}
