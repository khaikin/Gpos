using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GPos.Model
{
    internal class Product : INotifyPropertyChanged
    {
        private int _count = 0;
        decimal _price;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Total"));
                }
            }
        }


        public double Total { get { return Convert.ToDouble(Count * Price); } }


        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }
        public string Unit { get; set; }


        public Product()
        {

        }

        public Product(view_Product vPr)
        {
            Id = vPr.Id;
            Name = vPr.Name;
            Code = vPr.Code;
            Description = vPr.Description;
            Price = vPr.Price;
            Unit = vPr.Unit;
            Count = 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
