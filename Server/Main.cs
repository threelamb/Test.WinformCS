using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Comunication;
using APIAgent.Factory;

namespace Server
{
    public partial class Main : Form
    {
        SocketServer s;
        public Main()
        {
            InitializeComponent();

            this.cbx_Account.DataSource = new List<string>() { GetAccount() };
            this.cbx_Channel.DataSource = APIFactory.CreateOrder().GetDestinationList();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                SocketServer s = new SocketServer();
                s.Start();
                this.btn_Start.Enabled = false;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private string GetAccount()
        {
            string Account = string.Empty;
            try
            {
                var account = APIFactory.CreateAccount();
                var rs = account.GetAccount();
                Account = rs;
            }
            catch (Exception)
            {
            }
            return Account;
        }
    }
}
