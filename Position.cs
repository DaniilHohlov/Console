using System;
using System.Timers;


namespace MyConsole
{
    public class Position
    {
        public delegate void ChangePosition();

        public event ChangePosition PositionChanged;

        public Position()
        {
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += NewTrade;
            timer.Start();
        }

        public void NewTrade(object sender, ElapsedEventArgs e)
        {
            PositionChanged();

            Random random = new Random();

            string[] CurrencyPair = { "EUR", "USD" };

            string RandomPair = CurrencyPair[random.Next(0, CurrencyPair.Length)];

            int num = random.Next(-10, 10);
            TradeDirection direction;
            int newPrice = random.Next(70000, 80000);
            int ExitPrice = random.Next(70000, 80000);
            decimal StopLoss = newPrice;
            if (newPrice > ExitPrice)
            {
                StopLoss += (StopLoss * 6 / 100);
                direction = TradeDirection.Short;
            }
            else
            {
                StopLoss -= (StopLoss * 6 / 100);
                direction = TradeDirection.Long;
            }

            TradeManager manager = new TradeManager();
            Trade trade = new Trade(direction, RandomPair, Math.Abs(num), newPrice, random.Next(1, 5), ExitPrice, StopLoss);

            Console.WriteLine($"Новая сделка:");
            Console.WriteLine($"Направление: {trade.Direction}");
            Console.WriteLine($"Валюта: {trade.Pair}");
            Console.WriteLine($"Объем: {trade.Volume}");
            Console.WriteLine($"Цена входа: {trade.Price}");
            Console.WriteLine($"Количество открытых лотов: {trade.OpenLotsCount}");
            Console.WriteLine($"Цена выхода: {trade.TakeProfit}");
            Console.WriteLine($"Стоп Лосс: {trade.StopLoss}");
            Console.WriteLine($"Время создания: {trade.CreationTime}");

            manager.WriteTradeToFile(trade);
        }
    }
}
