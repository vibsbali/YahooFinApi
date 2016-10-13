using YahooFinApi.HttpServer;

namespace YahooFinApi.Console
{
    class Program
    {
        static void Main()
        {
            var client = new QuotesRetriever();
            var stock = "LNK.AX";
            //We can use C#6 interpolation to pass various parameters such as BHP.AX, date and so forth
            //here a is starting month, b is starting day, c is year and d is ending month etc. Note the month is 0 based. i.e. January is 0 and December 11
            //the query string q = w means weekly and d will mean daily prices
            System.Console.WriteLine(client.DownloadDataAsync($"http://real-chart.finance.yahoo.com/table.csv?s={stock}&a=0&b=1&c=2015&d=10&e=12&f=2016&g=d&ignore=.csv").Result);
        }
    }
}
