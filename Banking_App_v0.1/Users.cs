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
        public Users()
        {
            InitializeComponent();
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
            try
            {
                //User[] listUsers = new User[] {
                //    new User(1, "Jon"),
                //        new User(2, "James"),
                //        new User(3, "Sarah"),
                //        new User(4, "Matt"),
                //        new User(5, "Syndey")
                //};
                //cmbBoxUsers.DataSource = listUsers;
                //cmbBoxUsers.DisplayMember = "Name";

                //var arrUsers = new [] { "John", "James", "Sarah", "Matt", "Sydney" };
                //var listUsers = new List<string> { "John", "James", "Sarah", "Matt", "Sydney" };
                //cmbBoxUsers.DataSource = listUsers;
                //cmbBoxUsers.DisplayMember = "Name";
                //The above code works, but does not allow a new user to be added due to the DataSource already being set
                cmbBoxUsers.Items.Add("John");
                cmbBoxUsers.Items.Add("James");
                cmbBoxUsers.Items.Add("Sarah");
                cmbBoxUsers.Items.Add("Matt");
                cmbBoxUsers.Items.Add("Sydney");
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
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
    }
}
