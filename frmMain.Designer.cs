
namespace DowningM_FinalProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenuShop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuShopGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuHelpMePlease = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMadMaxGaming = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hlpMadMaxGamingInstructions = new System.Windows.Forms.HelpProvider();
            this.mnuMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.BackColor = System.Drawing.Color.Red;
            this.mnuMainMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuShop,
            this.mnuMainMenuHelp,
            this.mnuMainMenuExit});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(705, 24);
            this.mnuMainMenuStrip.TabIndex = 0;
            this.mnuMainMenuStrip.Text = "menuStrip1";
            // 
            // mnuMainMenuShop
            // 
            this.mnuMainMenuShop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuShopGames});
            this.mnuMainMenuShop.Name = "mnuMainMenuShop";
            this.mnuMainMenuShop.Size = new System.Drawing.Size(52, 20);
            this.mnuMainMenuShop.Text = "Shop";
            // 
            // mnuMainMenuShopGames
            // 
            this.mnuMainMenuShopGames.Name = "mnuMainMenuShopGames";
            this.mnuMainMenuShopGames.Size = new System.Drawing.Size(155, 22);
            this.mnuMainMenuShopGames.Text = "Shop Games";
            this.mnuMainMenuShopGames.Click += new System.EventHandler(this.mnuMainMenuShopGames_Click);
            // 
            // mnuMainMenuHelp
            // 
            this.mnuMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenuHelpMePlease,
            this.mnuMainMenuAbout});
            this.mnuMainMenuHelp.Name = "mnuMainMenuHelp";
            this.mnuMainMenuHelp.Size = new System.Drawing.Size(49, 20);
            this.mnuMainMenuHelp.Text = "Help";
            // 
            // mnuMainMenuHelpMePlease
            // 
            this.mnuMainMenuHelpMePlease.Name = "mnuMainMenuHelpMePlease";
            this.mnuMainMenuHelpMePlease.Size = new System.Drawing.Size(173, 22);
            this.mnuMainMenuHelpMePlease.Text = "Help Me Please";
            this.mnuMainMenuHelpMePlease.Click += new System.EventHandler(this.mnuMainMenuHelpMePlease_Click);
            // 
            // mnuMainMenuAbout
            // 
            this.mnuMainMenuAbout.Name = "mnuMainMenuAbout";
            this.mnuMainMenuAbout.Size = new System.Drawing.Size(173, 22);
            this.mnuMainMenuAbout.Text = "About";
            this.mnuMainMenuAbout.Click += new System.EventHandler(this.mnuMainMenuAbout_Click);
            // 
            // mnuMainMenuExit
            // 
            this.mnuMainMenuExit.Name = "mnuMainMenuExit";
            this.mnuMainMenuExit.Size = new System.Drawing.Size(41, 20);
            this.mnuMainMenuExit.Text = "Exit";
            this.mnuMainMenuExit.Click += new System.EventHandler(this.mnuMainMenuExit_Click);
            // 
            // lblMadMaxGaming
            // 
            this.lblMadMaxGaming.BackColor = System.Drawing.Color.Transparent;
            this.lblMadMaxGaming.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadMaxGaming.ForeColor = System.Drawing.Color.Red;
            this.lblMadMaxGaming.Location = new System.Drawing.Point(106, 400);
            this.lblMadMaxGaming.Name = "lblMadMaxGaming";
            this.lblMadMaxGaming.Size = new System.Drawing.Size(511, 75);
            this.lblMadMaxGaming.TabIndex = 1;
            this.lblMadMaxGaming.Text = "Mad Max Gaming";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click shop to see games";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowningM_FinalProject.Properties.Resources.madmaxgamingbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMadMaxGaming);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.hlpMadMaxGamingInstructions.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenuStrip;
            this.Name = "frmMain";
            this.hlpMadMaxGamingInstructions.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mad Max Gaming";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuShop;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuShopGames;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuHelpMePlease;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenuAbout;
        private System.Windows.Forms.Label lblMadMaxGaming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider hlpMadMaxGamingInstructions;
    }
}

