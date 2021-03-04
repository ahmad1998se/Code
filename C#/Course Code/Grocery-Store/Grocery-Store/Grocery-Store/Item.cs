using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Store
{
     public class Item
    {
      public string ITEM_NO { set; get; }        public  string  ITEM_NAME { set; get; }
       public string PRICE { set; get; }
       public DateTime EXPIRATION_DATE;
        public override string ToString()
        {
            return string.Format("{0} {1} : {2}", this.ITEM_NO, this.ITEM_NAME, this.EXPIRATION_DATE);
        }
        //format ex
        /* public string _EXPIRATION_DATE
          {
              set
              {

                  try
                  {
                      if (DateTime.TryParse(value.ToString(), out EXPIRATION_DATE))
                      {
                          String.Format("{0:d/MM/yyyy}", EXPIRATION_DATE);
                      }
                  }
                  catch (Exception e)
                  {

                  }

              }
              get
              { return EXPIRATION_DATE; }

          }*/





    }
}
