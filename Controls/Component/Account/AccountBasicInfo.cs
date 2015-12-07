using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Common;

namespace Controls.Component
{
    public partial class AccountBasicInfo : UserControl
    {
        public AccountBasicInfo()
        {
            InitializeComponent();
        }

        private AccountModel _Account;

        public AccountModel Account
        {
            get
            {
                AccountModel res = new AccountModel();
                res.AccountName = this.tbx_AccountName.Text;
                res.Alias = this.cbb_Alias.SelectedItem.GetString();
                res.IP = this.tbx_IP.Text;
                res.IsEnable = this.cbx_Enable.Checked;
                res.Channel = this.cbb_Channel.SelectedItem.GetString();
                return res;
            }
            set
            {
                if (value != null)
                {
                    _Account = value;
                    this.tbx_AccountName.Text = value.AccountName;
                    if (!value.Alias.IsNullOrEmpity())
                        this.cbb_Alias.SelectedItem = value.Alias;
                    else
                    {
                        this.cbb_Alias.SelectedIndex = 0;
                    }

                    this.tbx_IP.Text = value.IP;
                    this.cbx_Enable.Checked = value.IsEnable;
                    if (value.Channel.IsNullOrEmpity())
                    {
                        if (this.cbb_Channel.Items != null && this.cbb_Channel.Items.Count > 0)
                        {
                            this.cbb_Channel.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        this.cbb_Channel.SelectedItem = value.Channel;
                    }
                }
            }
        }

        internal void SetChannelSource(List<string> source)
        {
            var value = this.cbb_Channel.SelectedValue;
            this.cbb_Channel.DataSource = source;
            if (value != null && source.Contains(value.ToString()))
            {
                this.cbb_Channel.SelectedItem = value;
            }
        }
    }
}
