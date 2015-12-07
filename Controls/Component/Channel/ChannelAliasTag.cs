using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Model;

namespace Controls.Component.Channel
{
    public partial class ChannelAliasTag : UserControl
    {
        public ChannelAliasTag()
        {
            InitializeComponent();
        }

        public Model.ChannelAliasModel _Data;
        public Model.ChannelAliasModel Data
        {
            get
            {
                GetUI();
                return _Data;
            }
            set
            {
                _Data = value;
                UpdateUI(_Data);
            }
        }

        private void GetUI()
        {
            _Data.Alias = this.tbx_Alias.Text;
        }

        private void UpdateUI(ChannelAliasModel _Data)
        {
            if (_Data == null)
            {
                _Data = new ChannelAliasModel();
            }
            else
            {
                this.lbl_ChannelName.Text = _Data.ChannelName;
                this.tbx_Alias.Text = _Data.Alias;
                if (_Data.Alias.IsNullOrEmpity())
                {
                    this.tbx_Alias.Text = _Data.Alias;
                }
            }
        }

        internal ChannelAliasModel GetAlias()
        {
            var res = new ChannelAliasModel();

            if (this.tbx_Alias.Text.Trim().IsNullOrEmpity())
            {
                res.Alias = this._Data.Alias;
            }
            res.ChannelName = this._Data.ChannelName;

            return res;
        }
    }
}
