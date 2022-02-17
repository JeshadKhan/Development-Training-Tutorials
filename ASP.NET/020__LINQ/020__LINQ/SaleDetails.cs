using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _020__LINQ
{
    public class SaleDetails
    {
        public int Sales { get; set; }
        public int Pages { get; set; }
        public string ID { get; set; }

        public static List<SaleDetails> GetSalesDetails()
        {
            List<SaleDetails> list = new List<SaleDetails>();
            list.Add(new SaleDetails { ID = "001", Pages = 678, Sales = 110000 });
            list.Add(new SaleDetails { ID = "002", Pages = 789, Sales = 60000 });
            list.Add(new SaleDetails { ID = "003", Pages = 456, Sales = 40000 });
            list.Add(new SaleDetails { ID = "004", Pages = 900, Sales = 80000 });
            list.Add(new SaleDetails { ID = "005", Pages = 456, Sales = 90000 });
            list.Add(new SaleDetails { ID = "006", Pages = 870, Sales = 50000 });
            list.Add(new SaleDetails { ID = "007", Pages = 675, Sales = 40000 });
            return list;
        }
    }
}