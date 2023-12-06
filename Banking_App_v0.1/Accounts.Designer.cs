namespace Banking_App_v0._1
{
    partial class Accounts
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
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBankBalance = new System.Windows.Forms.TextBox();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.btnReceiveMoney = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMoney
            // 
            this.btnSendMoney.Location = new System.Drawing.Point(12, 113);
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(100, 35);
            this.btnSendMoney.TabIndex = 0;
            this.btnSendMoney.Text = "Send Money";
            this.btnSendMoney.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // txtBankBalance
            // 
            this.txtBankBalance.Location = new System.Drawing.Point(12, 87);
            this.txtBankBalance.Name = "txtBankBalance";
            this.txtBankBalance.ReadOnly = true;
            this.txtBankBalance.Size = new System.Drawing.Size(141, 20);
            this.txtBankBalance.TabIndex = 5;
            this.txtBankBalance.Text = "£4,000";
            //this.txtBankBalance.TextChanged += new System.EventHandler(this.txtBankBalance_TextChanged);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalance.Location = new System.Drawing.Point(9, 66);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(106, 18);
            this.lblBankBalance.TabIndex = 5;
            this.lblBankBalance.Text = "Bank Balance:";
            // 
            // btnReceiveMoney
            // 
            this.btnReceiveMoney.Location = new System.Drawing.Point(118, 113);
            this.btnReceiveMoney.Name = "btnReceiveMoney";
            this.btnReceiveMoney.Size = new System.Drawing.Size(100, 35);
            this.btnReceiveMoney.TabIndex = 4;
            this.btnReceiveMoney.Text = "Receive Money";
            this.btnReceiveMoney.UseVisualStyleBackColor = true;
            this.btnReceiveMoney.Click += new System.EventHandler(this.btnReceiveMoney_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 391);
            this.Controls.Add(this.btnReceiveMoney);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.txtBankBalance);
            this.Controls.Add(this.btnSendMoney);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMoney;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBankBalance;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Button btnReceiveMoney;
    }
}