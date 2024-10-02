using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App_v0._1
{
    public partial class Users : Form
    {
        private bool isSendMoneyMode;
        public Users() : this(false)
        {
        }

        // Constructor with parameter for send money mode
        public Users(bool sendMoneyMode)
        {
            InitializeComponent();
            isSendMoneyMode = sendMoneyMode;
            PopulateSendMoneyBox();
        }

        public class User
        {
            public string Name { get; set; }

            public int Rank { get; set; }


            public User(int r, string n)
            {
                Rank = r;
                Name = n;
            }
        }

        private void PopulateSendMoneyBox()
        {
            cmbSend.Items.Insert(0, "£5");
            cmbSend.Items.Insert(0, "£10");
            cmbSend.Items.Insert(0, "£20");
            cmbSend.Items.Insert(0, "£50");
            cmbSend.Items.Insert(0, "£100");
            cmbSend.Items.Insert(0, "£500");
            cmbSend.Items.Insert(0, "£1000");
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.ShowDialog();
        }
        public class Roles
        {
            public string Role { get; set; }

            public int RoleId { get; set; }

            public Roles(int rid, string r)
            {
                RoleId = rid;
                Role = r;
            }
        }

        private void btnPopulateUsers_Click(object sender, EventArgs e)
        {
           if (isSendMoneyMode == true) 
               try
                {
                    cmbBoxUsers.Items.Add("John");
                    cmbBoxUsers.Items.Add("James");
                    cmbBoxUsers.Items.Add("Sarah");
                    cmbBoxUsers.Items.Add("Matt");
                    cmbBoxUsers.Items.Add("Sydney");
                }
                catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                }
            else
                try
                {
                    Roles[] listRoles = new Roles[]
                    {
                        new Roles(1, "Guest"),
                        new Roles(2, "Family Member"),
                        new Roles(3, "Friend"),
                        new Roles(4, "Colleague")
                    };
                    cmbBoxRoles.DataSource = listRoles;
                    cmbBoxRoles.DisplayMember = "Role";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }


        private void btnAddRole_Click(object sender, EventArgs e)
        {
            lblRoleGiven.Text = cmbBoxUsers.Text + " has the " + cmbBoxRoles.Text + " role";
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string newUser = txtNewUser.Text;
                Console.WriteLine(newUser);
                // Fix below code || Edit: Below code works due to not using a DataSource
                cmbBoxUsers.Items.Add(newUser);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        public void ShowForSendMoney()
        {
            isSendMoneyMode = true;
            this.Show();
            UpdateControlsVisiblity();
        }

        private void UpdateControlsVisiblity()
        {
            if (isSendMoneyMode)
            {
                lblRoleGiven.Visible = false;
                cmbBoxRoles.Visible = false;
                txtUsersDesc.Visible = false;
                btnAddRole.Visible = false;
                btnNewUser.Visible = false;
                txtNewUser.Visible = false;
                btnSend.Visible = true;
                cmbSend.Visible = true;
            }
            else
            {
                lblRoleGiven.Visible = true;
                cmbBoxRoles.Visible = true;
                txtUsersDesc.Visible = true;
                btnAddRole.Visible = true;
                btnNewUser.Visible = true;
                txtNewUser.Visible = true;
                btnSend.Visible = false;
                cmbSend.Visible = false;
            }
        }

        // Override the OnLoad method to update control visibility when the form loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlsVisiblity();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cmbSend.SelectedIndex == -1)
            {
                MessageBox.Show("Drop-down is blank!", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("The money you requested has been sent.", "Money Sent!", MessageBoxButtons.OK);
            }
        }
    }
}
