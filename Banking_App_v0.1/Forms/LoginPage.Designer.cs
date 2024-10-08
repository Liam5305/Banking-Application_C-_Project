﻿namespace Banking_App_v0._1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.lblVersionControl = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Location = new System.Drawing.Point(108, 194);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(85, 21);
            this.btnCancelLogin.TabIndex = 0;
            this.btnCancelLogin.Text = "Exit\r\n";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 21);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogo
            // 
            this.txtLogo.AcceptsReturn = true;
            this.txtLogo.AcceptsTab = true;
            this.txtLogo.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtLogo.Location = new System.Drawing.Point(12, 12);
            this.txtLogo.Multiline = true;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(181, 138);
            this.txtLogo.TabIndex = 4;
            this.txtLogo.Text = "Oxton Banking Co.";
            this.txtLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVersionControl
            // 
            this.lblVersionControl.AutoSize = true;
            this.lblVersionControl.Location = new System.Drawing.Point(12, 218);
            this.lblVersionControl.Name = "lblVersionControl";
            this.lblVersionControl.Size = new System.Drawing.Size(35, 13);
            this.lblVersionControl.TabIndex = 5;
            this.lblVersionControl.Text = "label1";
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.InitialImage = null;
            this.imgBox.Location = new System.Drawing.Point(199, 12);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(333, 240);
            this.imgBox.TabIndex = 6;
            this.imgBox.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 264);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.lblVersionControl);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.Text = "Banking Application";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label lblVersionControl;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

