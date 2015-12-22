using GPos.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPos
{
    public partial class frmQuantity : Form, INotifyPropertyChanged
    {
        public frmQuantity()
        {
            InitializeComponent();
            Binding b = new Binding("Text", this, "Count", false, DataSourceUpdateMode.OnPropertyChanged);

            txtCount.DataBindings.Add(b);
            b.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;

            Binding bp = new Binding("Text", this, "Price", false, DataSourceUpdateMode.OnPropertyChanged);

            txtPrice.DataBindings.Add(bp);
            bp.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
        }

        //   public int Count { get { return Convert.ToInt32(txtCount.Text); } set { txtCount.Text = value.ToString(); } }
        private int _count;
        double _price;
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
            }
        }


        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_count > 0)
                Count--;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Count++;
        }

        private void btnminus10_Click(object sender, EventArgs e)
        {
            if (_count - 10 < 0)
                Count = 0;
            else
                Count -= 10;

        }

        private void btnplus10_Click(object sender, EventArgs e)
        {
            Count += 10;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Count = 0;

            DialogResult = DialogResult.OK;
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            using (var n = new ucNumPad())
            {

                n.StartPosition = FormStartPosition.CenterParent;

                n.Value = Price;
                if (n.ShowDialog(this) == DialogResult.OK)
                    Price = n.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }


        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    this.Capture = true;
        //}

        //protected override void OnMouseCaptureChanged(EventArgs e)
        //{
        //    if (!this.Capture)
        //    {
        //        if (!this.RectangleToScreen(this.DisplayRectangle).Contains(Cursor.Position))
        //        {
        //            this.Close();
        //        }
        //        else
        //        {
        //            this.Capture = true;
        //        }
        //    }

        //    base.OnMouseCaptureChanged(e);
        //}
    }
}
