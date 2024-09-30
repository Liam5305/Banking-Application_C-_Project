namespace Banking_App_v0._1
{
    partial class AccountsReceiveMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsReceiveMoney));
            this.btnConfirmReceive = new System.Windows.Forms.Button();
            this.cmboReceiveMoneys = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmReceive
            // 
            this.btnConfirmReceive.Location = new System.Drawing.Point(97, 221);
            this.btnConfirmReceive.Name = "btnConfirmReceive";
            this.btnConfirmReceive.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmReceive.TabIndex = 1;
            this.btnConfirmReceive.Text = "Confirm";
            this.btnConfirmReceive.Click += new System.EventHandler(this.btnConfirmReceive_Click);
            // 
            // cmboReceiveMoneys
            // 
            this.cmboReceiveMoneys.Items.AddRange(new object[] {
            "£5",
            "£10",
            "£15",
            "£25",
            "£35",
            "£50",
            "£100",
            "£200",
            "£500",
            "£1000",
            "£5000"});
            this.cmboReceiveMoneys.Location = new System.Drawing.Point(76, 68);
            this.cmboReceiveMoneys.Name = "cmboReceiveMoneys";
            this.cmboReceiveMoneys.Size = new System.Drawing.Size(121, 21);
            this.cmboReceiveMoneys.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // AccountsReceiveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 291);
            this.Controls.Add(this.cmboReceiveMoneys);
            this.Controls.Add(this.btnConfirmReceive);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountsReceiveMoney";
            this.Text = "AccountsReceiveMoney";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmReceive;
        private System.Windows.Forms.ComboBox cmboReceiveMoneys;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
    }
}