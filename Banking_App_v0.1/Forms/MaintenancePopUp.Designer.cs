﻿namespace Banking_App_v0._1.Forms
{
    partial class MaintenancePopUp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnterMMode = new System.Windows.Forms.Button();
            this.btnExitMMode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // btnEnterMMode
            // 
            this.btnEnterMMode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnterMMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterMMode.Location = new System.Drawing.Point(12, 342);
            this.btnEnterMMode.Name = "btnEnterMMode";
            this.btnEnterMMode.Size = new System.Drawing.Size(119, 39);
            this.btnEnterMMode.TabIndex = 1;
            this.btnEnterMMode.Text = "Enter Maintenance";
            this.btnEnterMMode.UseVisualStyleBackColor = false;
            this.btnEnterMMode.Click += new System.EventHandler(this.btnEnterMMode_Click);
            // 
            // btnExitMMode
            // 
            this.btnExitMMode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExitMMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitMMode.Location = new System.Drawing.Point(212, 342);
            this.btnExitMMode.Name = "btnExitMMode";
            this.btnExitMMode.Size = new System.Drawing.Size(119, 39);
            this.btnExitMMode.TabIndex = 2;
            this.btnExitMMode.Text = "Exit Maintenance";
            this.btnExitMMode.UseVisualStyleBackColor = false;
            this.btnExitMMode.Click += new System.EventHandler(this.btnExitMMode_Click);
            // 
            // MaintenancePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 393);
            this.Controls.Add(this.btnExitMMode);
            this.Controls.Add(this.btnEnterMMode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaintenancePopUp";
            this.Text = "MaintenancePopUp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Button btnEnterMMode;
        private System.Windows.Forms.Button btnExitMMode;
    }
}