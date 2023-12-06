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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts accounts = new Accounts();
            accounts.ShowDialog();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.ShowDialog();
        }

        //private void btnMembers_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Members members = new Members();
        //    members.ShowDialog();
        //}
    }
}
