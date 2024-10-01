using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Banking_App_v0._1
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
            SetVersionLabel();
            ImgBoxSetUp();
        }
        private void SetVersionLabel()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersionControl.Text = $"Version: {version}";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
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
                await Task.Delay(300);
                txtPassword.BackColor = SystemColors.Window;
                //Console.WriteLine("Failed");
            }
        }

        private void ImgBoxSetUp()
        {
            imgBox.ImageLocation = @"C:\Users\liamr\source\repos\Banking-Application_C-_Project\Banking_App_v0.1\Resources\BankingAppLogo.png";
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?","Confirm Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
