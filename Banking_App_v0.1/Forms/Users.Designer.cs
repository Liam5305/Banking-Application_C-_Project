namespace Banking_App_v0._1
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsersDesc = new System.Windows.Forms.TextBox();
            this.cmbBoxUsers = new System.Windows.Forms.ComboBox();
            this.btnPopulateUsers = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cmbBoxRoles = new System.Windows.Forms.ComboBox();
            this.lblRoleGiven = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
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
            // txtUsersDesc
            // 
            this.txtUsersDesc.Location = new System.Drawing.Point(12, 27);
            this.txtUsersDesc.Multiline = true;
            this.txtUsersDesc.Name = "txtUsersDesc";
            this.txtUsersDesc.ReadOnly = true;
            this.txtUsersDesc.Size = new System.Drawing.Size(202, 86);
            this.txtUsersDesc.TabIndex = 1;
            this.txtUsersDesc.Text = "This page will allow the end user to view all users that have access, and be able" +
    " to add and remove users";
            this.txtUsersDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBoxUsers
            // 
            this.cmbBoxUsers.Location = new System.Drawing.Point(12, 147);
            this.cmbBoxUsers.Name = "cmbBoxUsers";
            this.cmbBoxUsers.Size = new System.Drawing.Size(202, 21);
            this.cmbBoxUsers.TabIndex = 4;
            // 
            // btnPopulateUsers
            // 
            this.btnPopulateUsers.Location = new System.Drawing.Point(234, 145);
            this.btnPopulateUsers.Name = "btnPopulateUsers";
            this.btnPopulateUsers.Size = new System.Drawing.Size(112, 23);
            this.btnPopulateUsers.TabIndex = 3;
            this.btnPopulateUsers.Text = "Populate Menus";
            this.btnPopulateUsers.UseVisualStyleBackColor = true;
            this.btnPopulateUsers.Click += new System.EventHandler(this.btnPopulateUsers_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(234, 174);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(112, 23);
            this.btnAddRole.TabIndex = 5;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cmbBoxRoles
            // 
            this.cmbBoxRoles.FormattingEnabled = true;
            this.cmbBoxRoles.Location = new System.Drawing.Point(12, 174);
            this.cmbBoxRoles.Name = "cmbBoxRoles";
            this.cmbBoxRoles.Size = new System.Drawing.Size(202, 21);
            this.cmbBoxRoles.TabIndex = 7;
            // 
            // lblRoleGiven
            // 
            this.lblRoleGiven.AutoSize = true;
            this.lblRoleGiven.Location = new System.Drawing.Point(231, 200);
            this.lblRoleGiven.Name = "lblRoleGiven";
            this.lblRoleGiven.Size = new System.Drawing.Size(0, 13);
            this.lblRoleGiven.TabIndex = 6;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(365, 450);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(112, 23);
            this.btnNewUser.TabIndex = 8;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(259, 452);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(100, 20);
            this.txtNewUser.TabIndex = 9;
            this.txtNewUser.Text = "Enter new user";
            this.txtNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 495);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.cmbBoxRoles);
            this.Controls.Add(this.lblRoleGiven);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnPopulateUsers);
            this.Controls.Add(this.cmbBoxUsers);
            this.Controls.Add(this.txtUsersDesc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.Text = "Users";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsersDesc;
        private System.Windows.Forms.ComboBox cmbBoxUsers;
        private System.Windows.Forms.Button btnPopulateUsers;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.ComboBox cmbBoxRoles;
        private System.Windows.Forms.Label lblRoleGiven;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}