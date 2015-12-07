using ClientBusiness.Account;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Controls.Component
{
    public partial class AccountSetting : Form
    {
        AccountBuz Buz = new AccountBuz();
        List<string> source;
        private AccountList accountList;
        private AccountModel account;
        ChannelList cdCannelList;
        ChannelList tyCannelList;
        bool IsNew;
        public AccountSetting(AccountList accList, AccountModel acc, bool isNew)
        {
            InitializeComponent();
            this.account = acc;
            this.IsNew = isNew;
            this.accountList = accList;
            source = Buz.GetDestinationByAccount(acc.AccountName);
            tyCannelList = new ChannelList(acc.TYChannelList, false);
            tyCannelList.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(tyCannelList);

            cdCannelList = new ChannelList(acc.CDChannelList, true);
            cdCannelList.Dock = DockStyle.Fill;
            this.tabPage2.Controls.Add(cdCannelList);

            this.accountBasicInfo1.SetChannelSource(source);
            this.tyCannelList.SetChannelSource(source);
            this.cdCannelList.SetChannelSource(source);
            this.accountBasicInfo1.Account = this.account;
        }

        private void btn_RefreshChannel_Click(object sender, EventArgs e)
        {
            Buz = new AccountBuz();
            List<string> source = Buz.GetDestinationByAccount(this.accountBasicInfo1.tbx_AccountName.Text);
            if (!source.IsNullOrEmpty<string>())
            {
                this.accountBasicInfo1.SetChannelSource(source);
                var sourceNew = source.Clone();
                this.tyCannelList.SetChannelSource(sourceNew);
                sourceNew = source.Clone();
                this.cdCannelList.SetChannelSource(sourceNew);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.account = GetAccount();
            SaveAccount(account);
            if (this.IsNew)
            {
                this.accountList.AddAccount(account);
            }
            else
            {
                this.accountList.Update(account);
            }

            this.Close();
        }

        private void SaveAccount(AccountModel res)
        {
            AccountBuz buz = new AccountBuz();
            buz.Save(res);
        }

        private AccountModel GetAccount()
        {
            account = this.accountBasicInfo1.Account;
            account.CDChannelList = this.cdCannelList.GetChannelList();
            account.TYChannelList = this.tyCannelList.GetChannelList();
            return account;
        }
    }
}
