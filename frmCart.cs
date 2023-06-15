using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DowningM_FinalProject
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            ProgOps.AddToCart(dgvCart);
            ProgOps.Totals(dgvCart, lblSubtotal, lblTaxAmount, lblNetTotal);
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            ProgOps.DGVClear(dgvCart);
            lblSubtotal.Text = "";
            lblTaxAmount.Text = "";
            lblNetTotal.Text = "";
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ProgOps.Remove(dgvCart);
            dgvCart.Rows.Clear();
            ProgOps.AddToCart(dgvCart);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //ProgOps.Totals(dgvCart, lblSubtotal, lblTaxAmount, lblNetTotal);
            //create an object of the Report
            CrystalReports.crptCheckOut checkout = new CrystalReports.crptCheckOut();
            //set database logon for report
            checkout.SetDatabaseLogon("mdowningsu212353", "1841116");
            //creat an object of the frmViewer to use crvViewer
            frmViewer viewer = new frmViewer();
            //set to null to clear crvViewer
            viewer.crvViewer.ReportSource = null;
            //set crvViewer to report object
            viewer.crvViewer.ReportSource = checkout;
            //show form with crvViewer on it
            viewer.Show();
        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals("4"))
            {
                double total = Convert.ToDouble(dgvCart["Quantity", e.RowIndex].Value) * Convert.ToDouble(dgvCart["PricePerUnit", e.RowIndex].Value);
                dgvCart["Total_Line_Cost", e.RowIndex].Value = total.ToString();
            }
        }
    }
}
