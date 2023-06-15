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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMainMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMainMenuHelpMePlease_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpMadMaxGamingInstructions.HelpNamespace);
        }

        private void mnuMainMenuShopGames_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            shop.ShowDialog();
        }

        private void mnuMainMenuAbout_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
            hlpMadMaxGamingInstructions.HelpNamespace = Application.StartupPath + "\\MadMaxGamingInstructions.chm";
        }
    }
}
