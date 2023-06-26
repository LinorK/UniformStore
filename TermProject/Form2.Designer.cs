
namespace TermProject
{
    partial class FrmHomePage
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
            this.lblChooseAction = new System.Windows.Forms.Label();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnFindPurchases = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChooseAction
            // 
            this.lblChooseAction.AutoSize = true;
            this.lblChooseAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAction.Location = new System.Drawing.Point(242, 170);
            this.lblChooseAction.Name = "lblChooseAction";
            this.lblChooseAction.Size = new System.Drawing.Size(197, 20);
            this.lblChooseAction.TabIndex = 1;
            this.lblChooseAction.Text = "What would you like to do?";
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(45, 249);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(162, 45);
            this.btnViewProducts.TabIndex = 2;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnFindPurchases
            // 
            this.btnFindPurchases.Location = new System.Drawing.Point(474, 249);
            this.btnFindPurchases.Name = "btnFindPurchases";
            this.btnFindPurchases.Size = new System.Drawing.Size(170, 45);
            this.btnFindPurchases.TabIndex = 3;
            this.btnFindPurchases.Text = "Find Purchases";
            this.btnFindPurchases.UseVisualStyleBackColor = true;
            this.btnFindPurchases.Click += new System.EventHandler(this.btnFindPurchases_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(264, 249);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(162, 45);
            this.btnViewAccount.TabIndex = 4;
            this.btnViewAccount.Text = "View Account";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.Location = new System.Drawing.Point(12, 402);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(61, 29);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(6, 21);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(76, 31);
            this.lblHello.TabIndex = 6;
            this.lblHello.Text = "Hello";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(80, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 46);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "School Uniform Outlet Store";
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 443);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.btnFindPurchases);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.lblChooseAction);
            this.Name = "FrmHomePage";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChooseAction;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnFindPurchases;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblTitle;
    }
}