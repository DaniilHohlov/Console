using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyConsole
{
    public enum TradeDirection
    {
        Long = 1,
        Short
    }
    public class Trade
    {
        public string Pair = "";
        public decimal Price = 0;
        public decimal Volume = 0;
        public int OpenLotsCount = 0;
        public decimal DealPrice;
        public DateTime DateTime;
        public DateTime CreationTime;
        public TradeDirection Direction;

        public Trade(TradeDirection direction, string pair, int volume, int price, int openLotsCount, decimal dealPrice)
        {
            Direction = direction;
            Pair = pair;
            Volume = volume;
            Price = price;
            OpenLotsCount = openLotsCount;
            DealPrice = dealPrice;
            CreationTime = DateTime.Now;
        }
    }
}
