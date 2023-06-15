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
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
            ProgOps.ProductCommand(cbxQuantity, dgvMain);
            ProgOps.ProductID.Clear();
            ProgOps.Name.Clear();
            ProgOps.Quantity.Clear();
        }

        private void frmShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDisposeDatabase();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cbxQuantity.SelectedItem != null)
            {
                ProgOps.DGVMainClickData(dgvMain, cbxQuantity);
                ProgOps.Amount(cbxQuantity.SelectedItem.ToString(), dgvMain);
                cbxQuantity.Items.RemoveAt(cbxQuantity.Items.Count - 1);
                dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[4].Value = Convert.ToInt32(dgvMain.Rows[dgvMain.CurrentCell.RowIndex].Cells[4].Value) - Int32.Parse(cbxQuantity.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Select A Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult response;
            response = MessageBox.Show("Would you like to continue shopping?", "Mad Max Gaming", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                frmCart scart = new frmCart();
                scart.ShowDialog();
            }
        } 

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProgOps.ComboCommand(cbxQuantity, dgvMain);
            switch (dgvMain.CurrentRow.Cells[5].Value.ToString())
            {
                case "0001":
                    pbxShop.Image = Image.FromFile(@"Pics\0001.jpeg");
                    break;
                case "0002":
                    pbxShop.Image = Image.FromFile(@"Pics\0002.jpg");
                    break;
                case "0003":
                    pbxShop.Image = Image.FromFile(@"Pics\0003.jpg");
                    break;
                case "0004":
                    pbxShop.Image = Image.FromFile(@"Pics\0004.jpg");
                    break;
                case "0005":
                    pbxShop.Image = Image.FromFile(@"Pics\0005.jpg");
                    break;
                case "0006":
                    pbxShop.Image = Image.FromFile(@"Pics\0006.jpg");
                    break;
                case "0007":
                    pbxShop.Image = Image.FromFile(@"Pics\0007.jpg");
                    break;
                case "0008":
                    pbxShop.Image = Image.FromFile(@"Pics\0008.jpg");
                    break;
                case "0009":
                    pbxShop.Image = Image.FromFile(@"Pics\0009.jpg");
                    break;
                case "0010":
                    pbxShop.Image = Image.FromFile(@"Pics\0010.jpg");
                    break;
            }
        }

        private void cbxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxQuantity.Text = cbxQuantity.SelectedIndex.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            //Your shopping cart
            frmCart two = new frmCart();
            two.Show();
        }
    }
}
