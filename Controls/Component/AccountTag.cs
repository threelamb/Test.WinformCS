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
    public partial class AccountTag : UserControl
    {
        private AccountList _accountList;
        private Account _account;

        public AccountTag(AccountList accountList, Model.Account account)
        {
            InitializeComponent();
            this._accountList = accountList;
            this.Account = account;

            RegisterEvent();
        }

        private void RegisterEvent()
        {
            this.tableLayoutPanel1.MouseDown += tableLayoutPanel1_Click;
            this.lbl_Account.MouseDown += tableLayoutPanel1_Click;
            this.lbl_Alias.MouseDown += tableLayoutPanel1_Click;
            this.lbl_IP.MouseDown += tableLayoutPanel1_Click;
            this.lbl_Status.MouseDown += tableLayoutPanel1_Click;

            this.tableLayoutPanel1.MouseLeave += tableLayoutPanel1_MouseLeave;
        }

        void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            Point mp = this.PointToClient(Control.MousePosition);
            if (mp.X < tableLayoutPanel1.Left
                || mp.X > tableLayoutPanel1.Right
                || mp.Y < tableLayoutPanel1.Top
                || mp.Y > tableLayoutPanel1.Bottom
                )
            {
                this.BackColor = Color.White;
                if (this._accountList.Current == this)
                {
                    this.BackColor = Color.Red;
                }
                else if (this.Account.IsConnected)
                {
                    this.BackColor = Color.Green;
                }
            }
        }

        void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            this._accountList.Current = this;
            this.BackColor = Color.Red;
        }

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
                if (this._accountList.Current == this)
                {
                    this.BackColor = Color.Red;
                }
                else if (_account.IsConnected)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.White;
                }
                
            }
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

        internal void UnCheck()
        {
            if (this.Account.IsConnected)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        internal void Check()
        {
            this.BackColor = Color.Red;
        }
    }
}
