using System;
using YahooFinApi.HttpServer;
using YahooFinApi.Core;

namespace YahooFinApi.Console
{
    class Program
    {
        static void Main()
        {
            var client = new QuotesRetriever("http://real-chart.finance.yahoo.com/table.csv");
            var stock = "LNK.AX";
            //We can use C#6 interpolation to pass various parameters such as BHP.AX, date and so forth
            //here a is starting month, b is starting day, c is year and d is ending month etc. Note the month is 0 based. i.e. January is 0 and December 11
            //the query string g = w means weekly and d will means daily prices
            try
            {
                System.Console.WriteLine(client.DownloadDataAsync(queryString: $"?s={stock}&a=0&b=01&c=2000&d=5&e={Months.December}&f=2016&g=w&ignore=.csv").Result);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }


            System.Console.WriteLine(client.DownloadDataAsync(queryString: "?s=FXJ.AX&a=0&b=1&c=2000&d=5&e=11&f=2016&g=w&ignore=.csv").Result);


        }
    }
}
