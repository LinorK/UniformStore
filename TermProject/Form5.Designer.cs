
namespace TermProject
{
    partial class FrmPurchases
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
            this.btnPurBack = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lblPurchasesTitle = new System.Windows.Forms.Label();
            this.btnViewDate = new System.Windows.Forms.Button();
            this.btnViewPrice = new System.Windows.Forms.Button();
            this.lbxPurchases = new System.Windows.Forms.ListBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnViewPur2 = new System.Windows.Forms.Button();
            this.txbLowRange = new System.Windows.Forms.TextBox();
            this.txbUpRange = new System.Windows.Forms.TextBox();
            this.lblLowRange = new System.Windows.Forms.Label();
            this.lblUpRange = new System.Windows.Forms.Label();
            this.lblDollarSign1 = new System.Windows.Forms.Label();
            this.lblDollarSign2 = new System.Windows.Forms.Label();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPurBack
            // 
            this.btnPurBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPurBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPurBack.Location = new System.Drawing.Point(13, 406);
            this.btnPurBack.Name = "btnPurBack";
            this.btnPurBack.Size = new System.Drawing.Size(53, 28);
            this.btnPurBack.TabIndex = 0;
            this.btnPurBack.Text = "Back";
            this.btnPurBack.UseVisualStyleBackColor = false;
            this.btnPurBack.Click += new System.EventHandler(this.btnPurBack_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(34, 100);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(134, 44);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All Purchases";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lblPurchasesTitle
            // 
            this.lblPurchasesTitle.AutoSize = true;
            this.lblPurchasesTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasesTitle.Location = new System.Drawing.Point(164, 35);
            this.lblPurchasesTitle.Name = "lblPurchasesTitle";
            this.lblPurchasesTitle.Size = new System.Drawing.Size(248, 41);
            this.lblPurchasesTitle.TabIndex = 2;
            this.lblPurchasesTitle.Text = "Your Purchases";
            // 
            // btnViewDate
            // 
            this.btnViewDate.Location = new System.Drawing.Point(215, 100);
            this.btnViewDate.Name = "btnViewDate";
            this.btnViewDate.Size = new System.Drawing.Size(145, 44);
            this.btnViewDate.TabIndex = 3;
            this.btnViewDate.Text = "View Purchases Within Date Range";
            this.btnViewDate.UseVisualStyleBackColor = true;
            this.btnViewDate.Click += new System.EventHandler(this.btnViewDate_Click);
            // 
            // btnViewPrice
            // 
            this.btnViewPrice.Location = new System.Drawing.Point(407, 100);
            this.btnViewPrice.Name = "btnViewPrice";
            this.btnViewPrice.Size = new System.Drawing.Size(143, 44);
            this.btnViewPrice.TabIndex = 4;
            this.btnViewPrice.Text = "View Purchases Within Price Range";
            this.btnViewPrice.UseVisualStyleBackColor = true;
            this.btnViewPrice.Click += new System.EventHandler(this.btnViewPrice_Click);
            // 
            // lbxPurchases
            // 
            this.lbxPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPurchases.FormattingEnabled = true;
            this.lbxPurchases.HorizontalScrollbar = true;
            this.lbxPurchases.Location = new System.Drawing.Point(34, 295);
            this.lbxPurchases.Name = "lbxPurchases";
            this.lbxPurchases.Size = new System.Drawing.Size(516, 95);
            this.lbxPurchases.TabIndex = 5;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(185, 175);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 6;
            this.dateStart.Visible = false;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(185, 221);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 7;
            this.dateEnd.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(184, 162);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(183, 208);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Visible = false;
            // 
            // btnViewPur2
            // 
            this.btnViewPur2.Location = new System.Drawing.Point(234, 256);
            this.btnViewPur2.Name = "btnViewPur2";
            this.btnViewPur2.Size = new System.Drawing.Size(103, 27);
            this.btnViewPur2.TabIndex = 10;
            this.btnViewPur2.Text = "Go!";
            this.btnViewPur2.UseVisualStyleBackColor = true;
            this.btnViewPur2.Visible = false;
            this.btnViewPur2.Click += new System.EventHandler(this.btnViewPur2_Click);
            // 
            // txbLowRange
            // 
            this.txbLowRange.Location = new System.Drawing.Point(243, 175);
            this.txbLowRange.Name = "txbLowRange";
            this.txbLowRange.Size = new System.Drawing.Size(82, 20);
            this.txbLowRange.TabIndex = 11;
            this.txbLowRange.Visible = false;
            // 
            // txbUpRange
            // 
            this.txbUpRange.Location = new System.Drawing.Point(243, 221);
            this.txbUpRange.Name = "txbUpRange";
            this.txbUpRange.Size = new System.Drawing.Size(82, 20);
            this.txbUpRange.TabIndex = 12;
            this.txbUpRange.Visible = false;
            // 
            // lblLowRange
            // 
            this.lblLowRange.AutoSize = true;
            this.lblLowRange.Location = new System.Drawing.Point(214, 162);
            this.lblLowRange.Name = "lblLowRange";
            this.lblLowRange.Size = new System.Drawing.Size(146, 13);
            this.lblLowRange.TabIndex = 13;
            this.lblLowRange.Text = "Enter amount for lower range:";
            this.lblLowRange.Visible = false;
            // 
            // lblUpRange
            // 
            this.lblUpRange.AutoSize = true;
            this.lblUpRange.Location = new System.Drawing.Point(214, 206);
            this.lblUpRange.Name = "lblUpRange";
            this.lblUpRange.Size = new System.Drawing.Size(148, 13);
            this.lblUpRange.TabIndex = 14;
            this.lblUpRange.Text = "Enter amount for upper range:";
            this.lblUpRange.Visible = false;
            // 
            // lblDollarSign1
            // 
            this.lblDollarSign1.AutoSize = true;
            this.lblDollarSign1.Location = new System.Drawing.Point(225, 178);
            this.lblDollarSign1.Name = "lblDollarSign1";
            this.lblDollarSign1.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSign1.TabIndex = 15;
            this.lblDollarSign1.Text = "$";
            this.lblDollarSign1.Visible = false;
            // 
            // lblDollarSign2
            // 
            this.lblDollarSign2.AutoSize = true;
            this.lblDollarSign2.Location = new System.Drawing.Point(225, 224);
            this.lblDollarSign2.Name = "lblDollarSign2";
            this.lblDollarSign2.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSign2.TabIndex = 16;
            this.lblDollarSign2.Text = "$";
            this.lblDollarSign2.Visible = false;
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(234, 256);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(103, 27);
            this.btnGo2.TabIndex = 17;
            this.btnGo2.Text = "Go!";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Visible = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // FrmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 446);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.lblDollarSign2);
            this.Controls.Add(this.lblDollarSign1);
            this.Controls.Add(this.lblUpRange);
            this.Controls.Add(this.lblLowRange);
            this.Controls.Add(this.txbUpRange);
            this.Controls.Add(this.txbLowRange);
            this.Controls.Add(this.btnViewPur2);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lbxPurchases);
            this.Controls.Add(this.btnViewPrice);
            this.Controls.Add(this.btnViewDate);
            this.Controls.Add(this.lblPurchasesTitle);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnPurBack);
            this.Name = "FrmPurchases";
            this.Text = "Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPurBack;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label lblPurchasesTitle;
        private System.Windows.Forms.Button btnViewDate;
        private System.Windows.Forms.Button btnViewPrice;
        private System.Windows.Forms.ListBox lbxPurchases;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnViewPur2;
        private System.Windows.Forms.TextBox txbLowRange;
        private System.Windows.Forms.TextBox txbUpRange;
        private System.Windows.Forms.Label lblLowRange;
        private System.Windows.Forms.Label lblUpRange;
        private System.Windows.Forms.Label lblDollarSign1;
        private System.Windows.Forms.Label lblDollarSign2;
        private System.Windows.Forms.Button btnGo2;
    }
}