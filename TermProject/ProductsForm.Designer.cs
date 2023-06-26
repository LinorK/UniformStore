
namespace TermProject
{
    partial class FrmProducts
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblSelectedItemShow = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txbItemID = new System.Windows.Forms.TextBox();
            this.lblCartShow = new System.Windows.Forms.Label();
            this.lblCurrTtl = new System.Windows.Forms.Label();
            this.btnPrdBack = new System.Windows.Forms.Button();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.lblWarningMessage = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(48, 106);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(233, 147);
            this.lstProducts.TabIndex = 0;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Location = new System.Drawing.Point(290, 129);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(235, 23);
            this.btnSelectItem.TabIndex = 2;
            this.btnSelectItem.Text = "Select This Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_OnClick);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItem.Location = new System.Drawing.Point(408, 174);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(117, 15);
            this.lblSelectedItem.TabIndex = 3;
            this.lblSelectedItem.Text = "Your selected item...";
            // 
            // lblSelectedItemShow
            // 
            this.lblSelectedItemShow.AutoSize = true;
            this.lblSelectedItemShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItemShow.Location = new System.Drawing.Point(287, 174);
            this.lblSelectedItemShow.Name = "lblSelectedItemShow";
            this.lblSelectedItemShow.Size = new System.Drawing.Size(99, 15);
            this.lblSelectedItemShow.TabIndex = 4;
            this.lblSelectedItemShow.Text = "Selected Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(287, 230);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 15);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(356, 229);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(34, 20);
            this.txbQuantity.TabIndex = 6;
            this.txbQuantity.TextChanged += new System.EventHandler(this.TxbQuantity_TextChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(174, 306);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(242, 50);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "MAKE PURCHASE";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_OnClick);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(287, 213);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(295, 13);
            this.lblEntry.TabIndex = 8;
            this.lblEntry.Text = "Only enter a number, no spaces, do not enter a \"backspace\"";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(287, 106);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(129, 13);
            this.lblItemID.TabIndex = 9;
            this.lblItemID.Text = "Enter ID of selected item: ";
            // 
            // txbItemID
            // 
            this.txbItemID.Location = new System.Drawing.Point(450, 103);
            this.txbItemID.Name = "txbItemID";
            this.txbItemID.Size = new System.Drawing.Size(75, 20);
            this.txbItemID.TabIndex = 10;
            // 
            // lblCartShow
            // 
            this.lblCartShow.AutoSize = true;
            this.lblCartShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartShow.Location = new System.Drawing.Point(425, 9);
            this.lblCartShow.Name = "lblCartShow";
            this.lblCartShow.Size = new System.Drawing.Size(51, 20);
            this.lblCartShow.TabIndex = 11;
            this.lblCartShow.Text = "label1";
            // 
            // lblCurrTtl
            // 
            this.lblCurrTtl.AutoSize = true;
            this.lblCurrTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTtl.Location = new System.Drawing.Point(214, 282);
            this.lblCurrTtl.Name = "lblCurrTtl";
            this.lblCurrTtl.Size = new System.Drawing.Size(126, 18);
            this.lblCurrTtl.TabIndex = 12;
            this.lblCurrTtl.Text = "Purchase Amount";
            // 
            // btnPrdBack
            // 
            this.btnPrdBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrdBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrdBack.Location = new System.Drawing.Point(12, 416);
            this.btnPrdBack.Name = "btnPrdBack";
            this.btnPrdBack.Size = new System.Drawing.Size(53, 29);
            this.btnPrdBack.TabIndex = 13;
            this.btnPrdBack.Text = "Back";
            this.btnPrdBack.UseVisualStyleBackColor = false;
            this.btnPrdBack.Click += new System.EventHandler(this.btnPrdBack_Click);
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.AutoSize = true;
            this.lblProductsTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsTitle.Location = new System.Drawing.Point(186, 30);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(220, 41);
            this.lblProductsTitle.TabIndex = 14;
            this.lblProductsTitle.Text = "Our Products";
            // 
            // lblWarningMessage
            // 
            this.lblWarningMessage.AutoSize = true;
            this.lblWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningMessage.Location = new System.Drawing.Point(93, 374);
            this.lblWarningMessage.Name = "lblWarningMessage";
            this.lblWarningMessage.Size = new System.Drawing.Size(409, 15);
            this.lblWarningMessage.TabIndex = 15;
            this.lblWarningMessage.Text = "Please note: If account balance exceeds $150, purchase cannot be made.";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(100, 399);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 16;
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 457);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblWarningMessage);
            this.Controls.Add(this.lblProductsTitle);
            this.Controls.Add(this.btnPrdBack);
            this.Controls.Add(this.lblCurrTtl);
            this.Controls.Add(this.lblCartShow);
            this.Controls.Add(this.txbItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSelectedItemShow);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.lstProducts);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmProducts";
            this.Text = "Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label lblSelectedItemShow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txbItemID;
        private System.Windows.Forms.Label lblCartShow;
        private System.Windows.Forms.Label lblCurrTtl;
        private System.Windows.Forms.Button btnPrdBack;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Label lblWarningMessage;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}