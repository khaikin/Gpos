using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosDal
{
  public  class GlobalDal:BaseAdoDal
    {
        public GlobalDal(string connection):base(connection)
        {

        }

        public double Vat()
        {

            return Convert.ToDouble(base.ExecuteScalar("select Vatrate from udt_CONF_Global"));


        }


    }
}
