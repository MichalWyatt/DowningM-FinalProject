
namespace DowningM_FinalProject
{
    partial class frmCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.gbxTotals = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblNetTotalText = new System.Windows.Forms.Label();
            this.lblTaxAmountText = new System.Windows.Forms.Label();
            this.lblSubTotalText = new System.Windows.Forms.Label();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbxTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(12, 12);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(367, 270);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellValueChanged);
            // 
            // gbxTotals
            // 
            this.gbxTotals.BackColor = System.Drawing.Color.DimGray;
            this.gbxTotals.Controls.Add(this.lblSubtotal);
            this.gbxTotals.Controls.Add(this.lblTaxAmount);
            this.gbxTotals.Controls.Add(this.lblNetTotal);
            this.gbxTotals.Controls.Add(this.lblNetTotalText);
            this.gbxTotals.Controls.Add(this.lblTaxAmountText);
            this.gbxTotals.Controls.Add(this.lblSubTotalText);
            this.gbxTotals.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotals.Location = new System.Drawing.Point(12, 297);
            this.gbxTotals.Name = "gbxTotals";
            this.gbxTotals.Size = new System.Drawing.Size(192, 203);
            this.gbxTotals.TabIndex = 1;
            this.gbxTotals.TabStop = false;
            this.gbxTotals.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubtotal.Location = new System.Drawing.Point(11, 48);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(149, 27);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaxAmount.Location = new System.Drawing.Point(11, 102);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(149, 27);
            this.lblTaxAmount.TabIndex = 3;
            this.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNetTotal.Location = new System.Drawing.Point(11, 156);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(149, 27);
            this.lblNetTotal.TabIndex = 4;
            this.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetTotalText
            // 
            this.lblNetTotalText.Location = new System.Drawing.Point(11, 129);
            this.lblNetTotalText.Name = "lblNetTotalText";
            this.lblNetTotalText.Size = new System.Drawing.Size(149, 27);
            this.lblNetTotalText.TabIndex = 2;
            this.lblNetTotalText.Text = "Net Total";
            this.lblNetTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxAmountText
            // 
            this.lblTaxAmountText.Location = new System.Drawing.Point(11, 75);
            this.lblTaxAmountText.Name = "lblTaxAmountText";
            this.lblTaxAmountText.Size = new System.Drawing.Size(149, 27);
            this.lblTaxAmountText.TabIndex = 1;
            this.lblTaxAmountText.Text = "Tax Amount (8.25%)";
            this.lblTaxAmountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalText
            // 
            this.lblSubTotalText.Location = new System.Drawing.Point(11, 21);
            this.lblSubTotalText.Name = "lblSubTotalText";
            this.lblSubTotalText.Size = new System.Drawing.Size(149, 27);
            this.lblSubTotalText.TabIndex = 0;
            this.lblSubTotalText.Text = "Subtotal";
            this.lblSubTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.BackColor = System.Drawing.Color.Red;
            this.btnContinueShopping.Location = new System.Drawing.Point(231, 311);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(148, 34);
            this.btnContinueShopping.TabIndex = 2;
            this.btnContinueShopping.Text = "&Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.Red;
            this.btnClearCart.Location = new System.Drawing.Point(231, 362);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(148, 34);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "C&lear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(231, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(231, 464);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(148, 34);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check &Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DowningM_FinalProject.Properties.Resources.madmaxgamingbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 515);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnContinueShopping);
            this.Controls.Add(this.gbxTotals);
            this.Controls.Add(this.dgvCart);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mad Max Gaming Shopping Cart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbxTotals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.GroupBox gbxTotals;
        private System.Windows.Forms.Label lblNetTotalText;
        private System.Windows.Forms.Label lblTaxAmountText;
        private System.Windows.Forms.Label lblSubTotalText;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblNetTotal;
    }
}