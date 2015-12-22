
using PosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosBl
{
    public class ProductsBl:ProductDal
    {
       
        public ProductsBl(string connectionString):base(connectionString)
        {
           
        }

     
        public IQueryable<udt_Product> Products { get { return GetAll(); } }

    }
}
