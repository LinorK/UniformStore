
namespace TermProject
{
    partial class FrmNewAccount
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
            this.lblNewActTitle = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txbNewUser = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.btnCreateNewAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewActTitle
            // 
            this.lblNewActTitle.AutoSize = true;
            this.lblNewActTitle.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewActTitle.Location = new System.Drawing.Point(107, 41);
            this.lblNewActTitle.Name = "lblNewActTitle";
            this.lblNewActTitle.Size = new System.Drawing.Size(332, 41);
            this.lblNewActTitle.TabIndex = 0;
            this.lblNewActTitle.Text = "Create New Account";
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(146, 134);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(87, 20);
            this.lblNewUser.TabIndex = 1;
            this.lblNewUser.Text = "Username:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(146, 219);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(82, 20);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Password:";
            // 
            // txbNewUser
            // 
            this.txbNewUser.Location = new System.Drawing.Point(150, 157);
            this.txbNewUser.Name = "txbNewUser";
            this.txbNewUser.Size = new System.Drawing.Size(235, 20);
            this.txbNewUser.TabIndex = 3;
            // 
            // txbNewPass
            // 
            this.txbNewPass.Location = new System.Drawing.Point(150, 242);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(235, 20);
            this.txbNewPass.TabIndex = 4;
            // 
            // btnCreateNewAct
            // 
            this.btnCreateNewAct.Location = new System.Drawing.Point(200, 315);
            this.btnCreateNewAct.Name = "btnCreateNewAct";
            this.btnCreateNewAct.Size = new System.Drawing.Size(145, 35);
            this.btnCreateNewAct.TabIndex = 5;
            this.btnCreateNewAct.Text = "Create New Account";
            this.btnCreateNewAct.UseVisualStyleBackColor = true;
            this.btnCreateNewAct.Click += new System.EventHandler(this.btnCreateNewAct_Click);
            // 
            // FrmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 430);
            this.Controls.Add(this.btnCreateNewAct);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.txbNewUser);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.lblNewActTitle);
            this.Name = "FrmNewAccount";
            this.Text = "Create new account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewActTitle;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txbNewUser;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Button btnCreateNewAct;
    }
}