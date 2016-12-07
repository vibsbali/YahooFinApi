using System;
using System.Net;
using System.Threading.Tasks;

namespace YahooFinApi.HttpServer
{
    public class QuotesRetriever : IQuotesRetriever, IDisposable
    {
        private WebClient client;
        private readonly string baseAddress;

        public QuotesRetriever()
        {
            client = new WebClient();
        }

        public QuotesRetriever(string baseAddress)
        {
            this.baseAddress = baseAddress;
            client = new WebClient();
        }

        public async Task<string> DownloadDataAsync(string query = "", string queryString = "")
        {
            //check if the baseAddress was passed, if so, add queryString to the end 
            //otherwise pass query directly to DownloadQuotes method
            if (!string.IsNullOrEmpty(baseAddress))
            {
                query = baseAddress + queryString;
            }

            var downloadQuotes = Task.Run(() =>
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

            await downloadQuotes;

            //This is where an exception can be thrown by the TPL
            return downloadQuotes.Result;
        }

        #region DisposeCode
        // ReSharper disable once InconsistentNaming
        protected bool disposed;
        ~QuotesRetriever() { Dispose(false); }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                client = null;
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
