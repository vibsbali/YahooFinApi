using System;
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
            var downloadTask = Task.Run(() =>
            {
                try
                {
                   return client.DownloadString(new Uri(query));
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            });
            
           await downloadTask;
           return downloadTask.Result;
        }
    }
}
