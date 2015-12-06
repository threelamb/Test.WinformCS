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
    public partial class AccountList : UserControl
    {
        static int i = 0;
        List<AccountTag> ItemList = new List<AccountTag>();
        public AccountTag Current { get; set; }
        public AccountList()
        {
            InitializeComponent();
        }

        public void AddAccount(Account p)
        {
            AccountTag accountTag = new AccountTag(this, p);
            ItemList.Add(accountTag);
            accountTag.Dock = System.Windows.Forms.DockStyle.Fill;
            accountTag.Name = "accountTag" + (++i);
            accountTag.Padding = new System.Windows.Forms.Padding(2);
            accountTag.Size = new System.Drawing.Size(207, 27);
            accountTag.TabIndex = 1;
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
            Account acc = new Account();
            new AccountSetting(this, acc, true).ShowDialog();
        }

        internal void Update(Account account)
        {
            throw new NotImplementedException();
        }

        private void tsb_deleteAccount_Click(object sender, EventArgs e)
        {
            if (this.Current != null)
            {
                this.tlp_CountList.Controls.Remove(this.Current);
                this.ItemList.Remove(this.Current);
                if (this.ItemList.Count > 0)
                {
                    this.Current = this.ItemList.Last();
                    this.Current.Select();
                }
            }
        }
    }
}
