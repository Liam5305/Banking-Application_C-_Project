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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginPass = "123";

            if (txtPassword.Text == loginPass)
            {
                txtPassword.BackColor = Color.Green;
                this.Hide();
                Landing landing = new Landing();
                landing.ShowDialog();
                //Console.WriteLine("Accepted");
            }
            else
            {
                txtPassword.BackColor = Color.Red;
                //Console.WriteLine("Failed");
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
