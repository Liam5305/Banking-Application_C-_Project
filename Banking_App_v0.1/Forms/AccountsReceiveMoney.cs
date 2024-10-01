using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_App_v0._1
{
    public partial class AccountsReceiveMoney : Form
    {
        // Constructor for the AccountsReceiveMoney form
        public AccountsReceiveMoney()
        {
            InitializeComponent();
            // Attach event handlers
            btnConfirmReceive.Click += btnConfirmReceive_Click;
            cmboReceiveMoneys.SelectedIndexChanged += cmboReceiveMoneys_SelectedIndexChanged;
            // Disable the confirm button initially
            btnConfirmReceive.Enabled = false;
        }

        // Method to parse and return the selected money amount
        private decimal GetSelectedMoney()
        {
            if (cmboReceiveMoneys.SelectedItem != null)
            {
                string selectedValue = cmboReceiveMoneys.SelectedItem.ToString();
                // Remove the pound symbol and whitespace
                string numericValue = selectedValue.Replace("£", "").Trim();
                if (decimal.TryParse(numericValue, out decimal amount))
                {
                    return amount;
                }
            }
            return 0;
        }

        // Event handler for the Confirm button click
        private void btnConfirmReceive_Click(object sender, EventArgs e)
        {
            decimal selectedMoney = GetSelectedMoney();
            if (selectedMoney > 0)
            {
                // Add the money to the bank balance
                Classes.BankManager.AddMoney(selectedMoney);
                MessageBox.Show($"£{selectedMoney:F2} has been added to your bank balance.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Remove the selected item from the combo box
                if (cmboReceiveMoneys.SelectedIndex != -1)
                {
                    cmboReceiveMoneys.Items.RemoveAt(cmboReceiveMoneys.SelectedIndex);
                }
                // Reset the combo box selection
                cmboReceiveMoneys.SelectedIndex = -1;
                // Disable the confirm button
                btnConfirmReceive.Enabled = false;
            }
        }
        // Event handler for when the selected item in the combo box changes
        private void cmboReceiveMoneys_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmboReceiveMoneys.SelectedItem?.ToString();

            // Remove the pound symbol and any whitespace
            string numericValue = selectedValue?.Replace("£", "").Trim();

            if (decimal.TryParse(numericValue, out decimal amount))
            {
                if (amount > 0)
                {
                    // Enable the confirm button if a valid amount is selected
                    btnConfirmReceive.Enabled = true;
                    //Console.WriteLine($"Button enabled. Parsed amount: {amount}");
                }
                else
                {
                    // Disable the confirm button if the amount is 0 or negative
                    btnConfirmReceive.Enabled = false;
                    //Console.WriteLine("Button disabled: amount <= 0");
                }
            }
            else
            {
                // Disable the confirm button if parsing fails
                btnConfirmReceive.Enabled = false;
                //Console.WriteLine($"Button disabled: parsing failed for value: {selectedValue}");
            }
        }
    }
}
