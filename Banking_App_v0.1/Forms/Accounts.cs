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

namespace Banking_App_v0._1
{
    public partial class Accounts : Form
    {
        // Constructor for the Accounts form
        public Accounts()
        {
            InitializeComponent();
            BankManager.BalanceChanged += UpdateBalanceDisplay;
            // Update the balance display initially (£4000)
            UpdateBalanceDisplay(this, BankManager.Balance);
        }
        // Method to update the balance display
        public void UpdateBalanceDisplay(object sender, decimal balance)
        {
            // Check if invoke is required (for thread-safety)
            if (txtBankBalance.InvokeRequired)
            {
                // If invoke is required, use Invoke to update the text on the UI thread
                txtBankBalance.Invoke(new Action(() => txtBankBalance.Text = $"£{balance:F2}"));
            }
            else
            {
                // If invoke is not required, update the text directly
                txtBankBalance.Text = $"£{balance:F2}";
            }
        }
        // Event handler for the "Home Page" menu item click
        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create and show the Landing form
            Landing landing = new Landing();
            landing.ShowDialog();
        }
        // Event handler for the "Receive Money" button click
        private void btnReceiveMoney_Click(object sender, EventArgs e)
        {
            // Create and show the AccountsReceiveMoney form
            AccountsReceiveMoney accountsRecieveMoney = new AccountsReceiveMoney();
            accountsRecieveMoney.ShowDialog();
        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            // Pass true to indicate we're in "send money" mode
            Users users = new Users(true);
            this.Hide(); // Hide the current form
            users.ShowDialog();
            this.Show(); // Show the current form again when Users form is closed
        }
    }
}
