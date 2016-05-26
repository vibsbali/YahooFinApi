using System.Threading.Tasks;

namespace YahooFinApi.HttpServer
{
    public interface IQuotesRetriever
    {
        Task<string> DownloadDataAsync(string query = "", string queryString = "");
    }
}