using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APIAgent.Factory;
using APIAgent.Entity;
using Common.Entity;
using Common;

namespace TestSterlingAPI.Component
{
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string Account = GetAccount();
            if (!string.IsNullOrEmpty(Account))
            {
                this.tbx_Account.Text = Account;
            }

            this.cbx_Tif.DataSource = new Tifs().GetKeyValue<Tifs>();
            this.cbx_PriceType.DataSource = new PriceTypes().GetEnumKeyValue<PriceTypes>();
            this.cbx_PriceType.SelectedIndex = 1;
            this.cbx_Destination.DataSource = APIFactory.CreateOrder().GetDestinationList();
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

        private void btn_Shrt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(submitOrderFromUI(Side.Shrt));
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            MessageBox.Show(submitOrderFromUI(Side.Sell));
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(submitOrderFromUI(Side.Buy));
        }

        public string submitOrderFromUI(string Side)
        {
            string Account = this.tbx_Account.Text.Trim();
            string Symbol = this.tbx_Symbol.Text.Trim();
            string Quantity = this.tbx_Quantity.Text.Trim();
            string PriceType = ((KeyValue<string,string>)this.cbx_PriceType.SelectedItem).Value;
            string Tif = ((KeyValue<string,string>)this.cbx_Tif.SelectedItem).Value;
            string Destination = this.cbx_Destination.SelectedItem.ToString();
            return submitOrder(Account, Symbol, Quantity, Side, PriceType, Tif, Destination);
        }

        public string submitOrder(string Account, string Symbol, string Quantity, string Side, string PriceType, string Tif, string Destination)
        {
            string res = string.Empty;

            try
            {
                var order = APIFactory.CreateOrder();
                order.Account = Account;
                order.Symbol = Symbol;
                order.Quantity = Quantity;
                order.Side = Side;
                order.PriceType = (APIAgent.Entity.PriceTypes)Enum.Parse(typeof(APIAgent.Entity.PriceTypes), PriceType);
                order.Tif = Tif;
                order.Destination = Destination;
                order.ClOrderID = order.MakeClOrderID(order.Account);
                var rs = order.SubmitOrder();
                res = rs.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }

            return res;
        }
    }
}
