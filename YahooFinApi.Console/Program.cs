using YahooFinApi.HttpServer;

namespace YahooFinApi.Console
{
    class Program
    {
        static void Main()
        {
            var client = new QuotesRetriever("http://real-chart.finance.yahoo.com/table.csv");

            System.Console.WriteLine(client.DownloadDataAsync("","?s=BHP.AX&d=1&e=29&f=2016&g=d&a=0&b=29&c=1988&ignore=.csv").Result);
        }
    }
}
