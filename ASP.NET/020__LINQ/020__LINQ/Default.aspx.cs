using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _020__LINQ
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Get the books title and set to the label */
            List<Books> books = Books.GetBooks();
            var booksTitle = from b in books select b.Title;

            foreach (var title in booksTitle)
            {
                lblBooksTitle.Text += title.ToString() + "<br />";
            }


            /* Get the sale details and join with the books. set books title and pages to the label called 'BookDetails' */
            List<SaleDetails> sales = SaleDetails.GetSalesDetails();
            var booksTitleAndPagesList = from b in books
                                         join s in sales on b.ID equals s.ID
                                         select new { Title = b.Title, Pages = s.Pages };

            foreach (var booksTitleAndPages in booksTitleAndPagesList)
            {
                lblBooksDetail.Text += booksTitleAndPages.ToString() + "<br />";
            }


            /* Get the sale details and join with the books. set books title and sales to the label called 'BooksThatSalesTenThousandTimes' */
            /* And also order by sales */
            var booksTitleAndSalesList = from b in books
                                         join s in sales on b.ID equals s.ID
                                         where s.Sales >= 50000
                                         orderby s.Sales
                                         select new { Title = b.Title, Sales = s.Sales };

            foreach (var booksTitleAndSales in booksTitleAndSalesList)
            {
                lblBooksThatSalesTenThousandTimes.Text += booksTitleAndSales + "<br />";
            }


            /* Get the sale details and join with the books. set books title and sales to the label called 'BooksThatSalesTenThousandTimes' */
            var booksTitleAndTotalSaleList = from b in books
                                             join s in sales on b.ID equals s.ID
                                             let totalSale = b.Price * s.Sales
                                             select new { Title = b.Title, TotalSale = totalSale };

            foreach (var booksTitleAndTotalSale in booksTitleAndTotalSaleList)
            {
                lblBooksTitleAndTotalSale.Text += booksTitleAndTotalSale.ToString() + "<br />";
            }
        }
    }
}