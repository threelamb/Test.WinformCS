using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using ClientBusiness.Account;

namespace Controls.Component
{
    public partial class AccountList : UserControl
    {
        static int i = 0;
        string UserName;
        List<AccountTag> ItemList = new List<AccountTag>();

        private AccountTag _Current;

        public AccountTag Current
        {
            get { return _Current; }
            set
            {
                _Current = value;
                _Current.Check();
                foreach (var item in ItemList)
                {
                    if (item != _Current)
                    {
                        item.UnCheck();
                    }
                }

                SetButtons();
            }
        }

        private void SetButtons()
        {
            if (this.Current.Account.IsEnable)
            {
                tsb_connectAccount.Enabled = true;
                tsb_disconnectAccount.Enabled = true;
            }
            else
            {
                tsb_connectAccount.Enabled = false;
                tsb_disconnectAccount.Enabled = false;
            }

            if (this.Current.Account.IsConnected)
            {
                tsb_deleteAccount.Enabled = false;
                tsb_accountDetail.Enabled = false;
                tsb_enableAccount.Enabled = false;
                tsb_disableAccount.Enabled = false;
            }
            else
            {
                tsb_deleteAccount.Enabled = true;
                tsb_accountDetail.Enabled = true;
                tsb_enableAccount.Enabled = true;
                tsb_disableAccount.Enabled = true;
            }
        }

        public AccountList()
        {
            InitializeComponent();
            var Accounts = new AccountBuz().LoadAccounts(this.UserName);
            foreach (var item in Accounts)
            {
                AddAccount(item);
            }
        }

        public void AddAccount(AccountModel p)
        {
            AccountTag accountTag = new AccountTag(this, p);
            ItemList.Add(accountTag);
            accountTag.Dock = System.Windows.Forms.DockStyle.Fill;
            accountTag.Name = "accountTag" + (++i);
            accountTag.Padding = new System.Windows.Forms.Padding(2);
            accountTag.Size = new System.Drawing.Size(207, 27);
            accountTag.TabIndex = 1;
            this.tlp_CountList.RowCount = ItemList.Count + 1;
            this.tlp_CountList.RowStyles.Insert(0, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_CountList.Controls.Add(accountTag, 0, ItemList.Count - 1);
            Current = accountTag;
        }

        public void RemoveAccount()
        {

            this.tlp_CountList.Controls.Remove(this.Current);
            this.Current = (AccountTag)this.tlp_CountList.Controls[this.tlp_CountList.Controls.Count];
        }

        private void tsb_addAccount_Click(object sender, EventArgs e)
        {
            AccountModel acc = new AccountModel();
            new AccountSetting(this, acc, true).ShowDialog();
        }

        internal void Update(AccountModel account)
        {
            this.Current.Account = account;
        }

        private void tsb_deleteAccount_Click(object sender, EventArgs e)
        {
            if (this.Current != null)
            {
                this.tlp_CountList.Controls.Remove(this.Current);
                int index = this.ItemList.IndexOf(this.Current);
                this.ItemList.Remove(this.Current);
                if (this.ItemList.Count > 0)
                {
                    this.Current = this.ItemList.Last();
                }

                RefreshAcountList(index);
            }
        }

        private void RefreshAcountList(int index)
        {
            this.tlp_CountList.RowStyles.RemoveAt(index);
            this.tlp_CountList.RowCount -= 1;
            for (int i = 0; i < ItemList.Count; i++)
            {
                this.tlp_CountList.SetRow(ItemList[i], i);
            }
        }

        private void tsb_accountDetail_Click(object sender, EventArgs e)
        {
            if (this.Current == null)
            {
                new AccountSetting(this, new AccountModel(), true).Show();
            }
            else
            {
                new AccountSetting(this, this.Current.Account, false).Show();
            }
        }

        private void tsb_connectAccount_Click(object sender, EventArgs e)
        {
            this.Current.Account.IsConnected = true;
            this.Current = this.Current;
        }

        private void tsb_disconnectAccount_Click(object sender, EventArgs e)
        {
            this.Current.Account.IsConnected = false;
            this.Current = this.Current;
        }

        private void tsb_enableAccount_Click(object sender, EventArgs e)
        {
            this.Current.Account.IsEnable = true;
            this.Current = this.Current;
        }

        private void tsb_disableAccount_Click(object sender, EventArgs e)
        {
            this.Current.Account.IsEnable = false;
            this.Current = this.Current;
        }
    }
}
