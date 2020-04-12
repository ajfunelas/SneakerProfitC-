using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakerProfit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            costBox.Text = "0";
            sellpriceBox.Text = "0";
            shippingBox.Text = "0";
            feeBox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = Convert.ToDouble(costBox.Text);
            double sellPrice = Convert.ToDouble(sellpriceBox.Text);
            double shippingCost = Convert.ToDouble(shippingBox.Text);
            double fees = Convert.ToDouble(feeBox.Text);

            double profit = (sellPrice - cost) - (shippingCost - fees);

            resultLabel.Text = profit.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            costBox.Clear();
            sellpriceBox.Clear();
            shippingBox.Clear();
            feeBox.Clear();
            resultLabel.Text = "";
        }
    }
}
