using Banking_App_v0._1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App_v0._1.Forms
{
    public partial class MaintenancePopUp : Form
    {
        public MaintenancePopUp()
        {
            InitializeComponent();
            //MaintenanceMode.EnabledChanged += MaintenanceModeEnabled;
            //MaintenanceModeEnabled(this, MaintenanceMode.Enabled);
            btnExitMMode.Enabled = false;
        }


        private async void btnEnterMMode_Click(object sender, EventArgs e)
        {
            bool isEnabled = true;
            if (isEnabled == true)
            {
                btnExitMMode.Enabled = true;
                btnExitMMode.BackColor = Color.White;
                btnEnterMMode.BackColor = Color.Gray;
                btnEnterMMode.Enabled = false;
                MessageBox.Show("Maintenance Mode Enabled", "OK");
            }
            else
            {
                MessageBox.Show("Cannot Enable", "OK");
            }
            isEnabled = false;
        }

        private void btnExitMMode_Click(object sender, EventArgs e)
        {
            bool isEnabled = false;
            if (isEnabled == false)
            {
                btnExitMMode.Enabled = false;
                btnExitMMode.BackColor = Color.Gray;
                btnEnterMMode.BackColor = Color.White;
                btnEnterMMode.Enabled = true;
                MessageBox.Show("Maintenance Mode Disabled", "OK");
            }
            else
            {
                MessageBox.Show("Cannot Disable", "OK");
            }
            isEnabled = true;
        }

        //public void MaintenanceModeEnabled(object sender, bool enabled)
        //{
        //    //if (btnEnterMMode.InvokeRequired)
        //    //{
        //    //    btnEnterMMode.Invoke(new Action(() => btnEnterMMode.Enabled = false));
        //    //}
        //    //else
        //    //{
        //    //    btnExitMMode.Invoke(new Action(() => btnExitMMode.Enabled = false));
        //    //}
        //}

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.ShowDialog();
        }

    }
}
