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
            this.btnConfirmReceive = new System.Windows.Forms.Button();
            this.cmboReceiveMoneys = new System.Windows.Forms.ComboBox();
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
            // AccountsReceiveMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 291);
            this.Controls.Add(this.cmboReceiveMoneys);
            this.Controls.Add(this.btnConfirmReceive);
            this.Name = "AccountsReceiveMoney";
            this.Text = "AccountsReceiveMoney";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmReceive;
        private System.Windows.Forms.ComboBox cmboReceiveMoneys;
    }
}