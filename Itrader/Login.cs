using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Itrader
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.lbl_name.Text = Resource.Resource.lbl_name;
            this.lbl_password.Text = Resource.Resource.lbl_password;
            this.btn_login.Text = Resource.Resource.btn_login;
            this.btn_cancel.Text = Resource.Resource.btn_cancel;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }
    }
}
