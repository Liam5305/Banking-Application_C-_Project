﻿using System;
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
    public partial class AccountsReceiveMoney : Form
    {
        public AccountsReceiveMoney()
        {
            InitializeComponent();
        }

        private void btnConfirmReceive_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
