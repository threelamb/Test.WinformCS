using Common;
using ClientBusiness.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Controls
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = Resource.Resource.txt_login;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var mbox = string.Empty;
            var name = this.tbx_name.Text;
            var passwrod = this.tbx_password.Text;
            ILoginBuz LoginBiz = new LoginBuz();

            //if (LoginBiz.VerifyPara(ref mbox, name, passwrod)
            //    && LoginBiz.login(name, passwrod))
            if (true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, mbox, this.Text);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
