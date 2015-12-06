using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Controls.Component
{
    public partial class  AccountTag : UserControl
    {
        private AccountList _accountList;
        private Account _account;

        public Account Account
        {
            get { return _account; }
            set
            {
                this._account = value;
                this.lbl_Account.Text = _account.AccountName;
                this.lbl_Alias.Text = _account.Alias;
                this.lbl_IP.Text = _account.IP;
                this.lbl_Status.Text = _account.IsEnable ? "启用" : "禁用";
                this.BackColor = _account.IsConnected ? Color.Red : Color.White;
            }
        }

        public AccountTag(AccountList accountList, Model.Account account)
        {
            InitializeComponent();
            this._accountList = accountList;
            this.Account = account;
        }

        public void Enable()
        {
            this.lbl_Status.Text = "启用";
            _account.IsEnable = true;
        }

        public void Disable()
        {
            this.lbl_Status.Text = "禁用";
            _account.IsEnable = false;
        }

        public void Connect()
        {
            this.BackColor = Color.Red;
            _account.IsConnected = true;
        }

        public void Disconnect()
        {
            this.BackColor = Color.Wheat;
            _account.IsConnected = false;
        }

        private void AccountTag_Click(object sender, EventArgs e)
        {
            this._accountList.Current = this;
        }
    }
}
