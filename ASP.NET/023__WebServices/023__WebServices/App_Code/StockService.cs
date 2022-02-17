using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for StockService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class StockService : System.Web.Services.WebService
{

    public StockService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    string[,] stocks =
    {
        {"RELIND", "Reliance Industries", "1060.15"},
        {"ICICI", "ICICI Bank", "911.55"},
        {"JSW", "JSW Steel", "1201.25"},
        {"WIPRO", "Wipro Limited", "1194.65"},
        {"SATYAM", "Satyam Computers", "91.10"}
    };

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public double GetPrice(string symbol)
    {
        // It takes the symbol as parameter and returns price
        for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if (string.Compare(symbol, stocks[i, 0], true) == 0)
            {
                return Convert.ToDouble(stocks[i, 2]);
            }
        }

        return 0;
    }

    [WebMethod]
    public string GetName(string symbol)
    {
        // It takes the symbol as parameter and 
        // returns name of the stock
        for (int i = 0; i < stocks.GetLength(0); i++)
        {
            if (string.Compare(symbol, stocks[i, 0], true) == 0)
            {
                return stocks[i, 1];
            }
        }

        return "Stock Not Found.";
    }
}
