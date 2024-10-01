using Banking_App_v0._1.Forms;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.ShowDialog();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
             this.Hide();
             Users users = new Users();
             users.ShowDialog();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintenancePopUp mPopUp = new MaintenancePopUp();
            mPopUp.ShowDialog();
        }
    }
}
