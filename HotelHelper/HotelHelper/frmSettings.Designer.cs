namespace HotelHelper
{
    partial class frmSettings
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
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblReenterNewPassword = new System.Windows.Forms.Label();
            this.txtRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.White;
            this.lblChangePassword.Location = new System.Drawing.Point(335, 23);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(136, 16);
            this.lblChangePassword.TabIndex = 0;
            this.lblChangePassword.Text = "Change password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(333, 196);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(141, 33);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(335, 54);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(141, 26);
            this.txtOldPassword.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(335, 104);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(141, 26);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(212, 56);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(109, 20);
            this.lblOldPassword.TabIndex = 4;
            this.lblOldPassword.Text = "Old password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(210, 104);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(116, 20);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New password:";
            // 
            // lblReenterNewPassword
            // 
            this.lblReenterNewPassword.AutoSize = true;
            this.lblReenterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenterNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblReenterNewPassword.Location = new System.Drawing.Point(208, 140);
            this.lblReenterNewPassword.Name = "lblReenterNewPassword";
            this.lblReenterNewPassword.Size = new System.Drawing.Size(114, 40);
            this.lblReenterNewPassword.TabIndex = 6;
            this.lblReenterNewPassword.Text = "Re-enter the\r\nnew password:";
            this.lblReenterNewPassword.Click += new System.EventHandler(this.lblReenterNewPassword_Click);
            // 
            // txtRepeatNewPassword
            // 
            this.txtRepeatNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatNewPassword.Location = new System.Drawing.Point(335, 156);
            this.txtRepeatNewPassword.Name = "txtRepeatNewPassword";
            this.txtRepeatNewPassword.PasswordChar = '•';
            this.txtRepeatNewPassword.Size = new System.Drawing.Size(140, 26);
            this.txtRepeatNewPassword.TabIndex = 7;
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.btnCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(109, 51);
            this.btnCustomerInfo.TabIndex = 8;
            this.btnCustomerInfo.Text = "Change personal information";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(511, 312);
            this.Controls.Add(this.btnCustomerInfo);
            this.Controls.Add(this.txtRepeatNewPassword);
            this.Controls.Add(this.lblReenterNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblChangePassword);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblReenterNewPassword;
        private System.Windows.Forms.TextBox txtRepeatNewPassword;
        private System.Windows.Forms.Button btnCustomerInfo;
    }
}