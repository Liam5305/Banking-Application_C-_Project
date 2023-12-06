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
        public Accounts()
        {
            InitializeComponent();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.ShowDialog();
        }

        private void btnReceiveMoney_Click(object sender, EventArgs e)
        {
            AccountsReceiveMoney accountsRecieveMoney = new AccountsReceiveMoney();
            accountsRecieveMoney.ShowDialog();
        }
    }
}
