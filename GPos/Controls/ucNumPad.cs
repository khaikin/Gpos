using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace GPos.Controls
{
    public partial class ucNumPad : Form
    {
        public ucNumPad()
        {
            InitializeComponent();
            //    TopMost = true;

            txtPrice.TextChanged += TxtPrice_TextChanged;

            this.Controls.OfType<Button>().ToList().ForEach(d => d.TabStop = false);
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtPrice.Text))
            //{
            //    txtPrice.Text = "";


            //}

            //txtPrice.Text = Convert.ToDouble(txtPrice.Text).ToString("0.00");
        }

        public double Value { get { return Convert.ToDouble(txtPrice.Text); } set { txtPrice.Text = value.ToString(); } }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPrice.Text += "1";
            SetFocus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPrice.Text += "2";
            SetFocus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPrice.Text += "3";
            SetFocus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPrice.Text += "4";
            SetFocus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPrice.Text += "5";
            SetFocus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            txtPrice.Text += "6";
            SetFocus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            txtPrice.Text += "7";
            SetFocus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            txtPrice.Text += "8";
            SetFocus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            txtPrice.Text += "9";
            SetFocus();
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            txtPrice.Text += "0";
            SetFocus();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {


            if (txtPrice.Text.IndexOf('.') == -1)
                txtPrice.Text += ".";

            SetFocus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = string.Empty;
            SetFocus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                // return txtPrice.Text;
            }
            else
            {
                var str = txtPrice.Text;


                txtPrice.Text = str.Remove(str.Length - 1);


            }
            SetFocus();
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtmoveLeft_Click(object sender, EventArgs e)
        {
            txtPrice.Focus();
            if (txtPrice.SelectionStart > 0)
                txtPrice.SelectionStart--;
        }

        private void btnmooveright_Click(object sender, EventArgs e)
        {
            txtPrice.Focus();
            if (txtPrice.SelectionStart < txtPrice.Text.Length)
                txtPrice.SelectionStart++;
        }

        void SetFocus()
        {
            txtPrice.Focus();
            txtPrice.SelectionStart = txtPrice.Text.Length;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
                return;

            DialogResult = DialogResult.OK;
            
        }
    }
}
