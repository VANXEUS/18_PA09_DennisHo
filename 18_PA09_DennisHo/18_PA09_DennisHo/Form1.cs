using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_PA09_DennisHo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double ConvertedValue;

            try
            {
                AmountEntered = double.Parse(txt_Amount.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.");
            }

            //checking for null values
            if ((rdb_USD.Checked == false) || (rdb_JPY.Checked == false))
                txt_ConvertedAmount.Text = "Select at least one type of currency to convert";

            //convert SGD to US Dollars
            if(rdb_USD.Checked == true)
            {
                AmountEntered = double.Parse(txt_Amount.Text);
                ConvertedValue = AmountEntered * 0.74;

                txt_ConvertedAmount.Text = ConvertedValue.ToString();
            }

            if(rdb_JPY.Checked == true)
            {
                AmountEntered = double.Parse(txt_Amount.Text);
                ConvertedValue = AmountEntered * 81.97f;

                txt_ConvertedAmount.Text = ConvertedValue.ToString();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //unchecks the radio buttons
            rdb_JPY.Checked = false;
            rdb_USD.Checked = false;

            //removes text
            txt_Amount.Text = "";
            txt_ConvertedAmount.Text = "";
        }
    }
}
