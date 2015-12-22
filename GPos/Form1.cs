using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPos.Controls;
using GPos.Model;
using PosDal;

namespace GPos
{
    public partial class Form1 : Form
    {
        string _conectionString;
        BindingList<Product> products = new BindingList<Product>();
        double vat = 0;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Linen;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            productBindingSource.DataSource = products;
            products.ListChanged += Products_ListChanged;
        }

        private void Products_ListChanged(object sender, ListChangedEventArgs e)
        {
            var sum = products.Sum(d => d.Total);

            txtTotal.Text = sum.ToString();
            var vatSum = (sum * (vat / 100));
            txtVat.Text = vatSum.ToString("0.00");
            txtPay.Text = (sum + vatSum).ToString("0.00");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSettings())
            {
                frm.ShowDialog();


                var guid = frm.txtUnique.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _conectionString = ConfigurationManager.AppSettings["db"];
            try
            {
                var shorts = new PosDal.ProductDal(_conectionString).GetShortCuts();

                foreach (var item in shorts)
                {
                    var btn = new ShortCutButton { ProductId = item.Id, Text = item.Name, Tag = item };
                    btn.Click += Btn_Click;
                    flpshortcuts.Controls.Add(btn);
                }


            }
            catch (Exception ex)
            {

                throw;
            }
            for (int i = 0; i < 20; i++)
            {
                //flpshortcuts.Controls.Add(new ShortCutButton { ProductId = i,Text = "קיצור  "+i });
            }


            vat = new GlobalDal(_conectionString).Vat();

            lblVat.Text = string.Format(lblVat.Text, vat);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as ShortCutButton;
            if (btn == null) return;


            var vp = btn.Tag as view_Product;

            var pr = new Product(vp);
            AddOrUpdateProduct(pr);
        }

        private void AddOrUpdateProduct(Product pr)
        {
            var exist = products.FirstOrDefault(p => p.Id == pr.Id);

            if (exist == null)
                products.Add(pr);
            else
                exist.Count++;


            dataGridView1.Refresh();
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

 UpdateQuatity();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        void UpdateQuatity()
        {

            if (productBindingSource.Current == null) return;


            var pr = productBindingSource.Current as Product;


            using (var frm = new frmQuantity())
            {
                frm.Count = pr.Count;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Price =Convert.ToDouble( pr.Price);

                if (frm.ShowDialog(this) ==DialogResult.Cancel) return;

                if (frm.Count == 0)
                    productBindingSource.RemoveCurrent();
                else
                    pr.Count = frm.Count;


                pr.Price =Convert.ToDecimal( frm.Price);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}