
namespace TermProject
{
    partial class FrmAccount
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
            this.btnActBack = new System.Windows.Forms.Button();
            this.lblActTitle = new System.Windows.Forms.Label();
            this.lblCartTtlShow = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txbPayment = new System.Windows.Forms.TextBox();
            this.btnApplyPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActBack
            // 
            this.btnActBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActBack.Location = new System.Drawing.Point(13, 413);
            this.btnActBack.Name = "btnActBack";
            this.btnActBack.Size = new System.Drawing.Size(50, 25);
            this.btnActBack.TabIndex = 0;
            this.btnActBack.Text = "Back";
            this.btnActBack.UseVisualStyleBackColor = false;
            this.btnActBack.Click += new System.EventHandler(this.btnActBack_Click);
            // 
            // lblActTitle
            // 
            this.lblActTitle.AutoSize = true;
            this.lblActTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActTitle.Location = new System.Drawing.Point(147, 59);
            this.lblActTitle.Name = "lblActTitle";
            this.lblActTitle.Size = new System.Drawing.Size(138, 41);
            this.lblActTitle.TabIndex = 1;
            this.lblActTitle.Text = "Account";
            // 
            // lblCartTtlShow
            // 
            this.lblCartTtlShow.AutoSize = true;
            this.lblCartTtlShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTtlShow.Location = new System.Drawing.Point(180, 123);
            this.lblCartTtlShow.Name = "lblCartTtlShow";
            this.lblCartTtlShow.Size = new System.Drawing.Size(136, 20);
            this.lblCartTtlShow.TabIndex = 2;
            this.lblCartTtlShow.Text = "Your Cart Total:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(146, 204);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(165, 16);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.Text = "Enter Payment Amount     $";
            // 
            // txbPayment
            // 
            this.txbPayment.Location = new System.Drawing.Point(308, 202);
            this.txbPayment.Name = "txbPayment";
            this.txbPayment.Size = new System.Drawing.Size(100, 20);
            this.txbPayment.TabIndex = 4;
            // 
            // btnApplyPay
            // 
            this.btnApplyPay.Location = new System.Drawing.Point(208, 261);
            this.btnApplyPay.Name = "btnApplyPay";
            this.btnApplyPay.Size = new System.Drawing.Size(168, 42);
            this.btnApplyPay.TabIndex = 5;
            this.btnApplyPay.Text = "Apply Payment";
            this.btnApplyPay.UseVisualStyleBackColor = true;
            this.btnApplyPay.Click += new System.EventHandler(this.btnApplyPay_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btnApplyPay);
            this.Controls.Add(this.txbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblCartTtlShow);
            this.Controls.Add(this.lblActTitle);
            this.Controls.Add(this.btnActBack);
            this.Name = "FrmAccount";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActBack;
        private System.Windows.Forms.Label lblActTitle;
        private System.Windows.Forms.Label lblCartTtlShow;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txbPayment;
        private System.Windows.Forms.Button btnApplyPay;
    }
}