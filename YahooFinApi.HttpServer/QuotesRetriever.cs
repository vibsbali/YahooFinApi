using System.Net;

using System.Threading.Tasks;

namespace YahooFinApi.HttpServer
{
    public class QuotesRetriever
    {
        private readonly WebClient client;
        public QuotesRetriever()
        {
            client = new WebClient();
        }

        public async Task<string> DownloadData(string query)
        {
            var downloadTask = Task.Run(() => client.DownloadString(query));

            await downloadTask;
            return downloadTask.Result;
        }
    }
}
