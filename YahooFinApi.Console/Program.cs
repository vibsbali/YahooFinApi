using YahooFinApi.HttpServer;

namespace YahooFinApi.Console
{
    class Program
    {
        static void Main()
        {
            var client = new QuotesRetriever();

            //We can use C#6 interpolation to pass various parameters such as BHP.AX, date and so forth
            System.Console.WriteLine(client.DownloadDataAsync("http://real-chart.finance.yahoo.com/table.csv?s=BHP.AX&d=1&e=29&f=2016&g=d&a=0&b=29&c=1988&ignore=.csv").Result);
        }
    }
}
