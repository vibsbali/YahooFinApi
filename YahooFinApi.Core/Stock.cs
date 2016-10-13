using System;

namespace YahooFinApi.Core
{
    /// <summary>
    /// ADT for Stock Symbol and associated properties on ASX
    /// </summary>
    public class Stock
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public uint Volume { get; set; }
        public decimal OpeningPrice  { get; set; }
        public decimal ClosingPrice { get; set; }
        public decimal AdjustedClose { get; set; }
    }
}
