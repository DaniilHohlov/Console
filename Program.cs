using System;
using System.Threading;
using System.IO;
namespace MyConsole
{

    

public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                string[] CurrencyPair = {"EUR", "USD"};

                string RandomPair = CurrencyPair[random.Next(0, CurrencyPair.Length)];

                int num = random.Next(-10, 10);
                TradeDirection direction;
                int newPrice = random.Next(70000, 80000);
                int ExitPrice = random.Next(70000, 80000);
                if (newPrice > ExitPrice)
                {
                    direction = TradeDirection.Short;
                }
                else
                {
                    direction = TradeDirection.Long;
                }

                
                TradeManager manager = new TradeManager();
                Trade trade = new Trade(direction, RandomPair, Math.Abs(num), newPrice, random.Next(1, 5), ExitPrice);

                Console.WriteLine($"Новая сделка:");
                Console.WriteLine($"Направление: {trade.Direction}");
                Console.WriteLine($"Валюта: {trade.Pair}");
                Console.WriteLine($"Объем: {trade.Volume}");
                Console.WriteLine($"Цена входа: {trade.Price}");
                Console.WriteLine($"Количество открытых лотов: {trade.OpenLotsCount}");
                Console.WriteLine($"Цена выхода: {trade.DealPrice}");
                Console.WriteLine($"Время создания: {trade.CreationTime}");

                manager.WriteTradeToFile(trade);

                Thread.Sleep(5000);
            }
            

        }
    }



    //static void Main(string[] args)
    //{

    //Position position = new Position();



    //    //Console.Write("Задайте верхнюю цену: ");
    //    //double upPrice = double.Parse(Console.ReadLine());

    //    //Console.Write("Задайте нижнюю цену: ");
    //    //double downPrice = double.Parse(Console.ReadLine());

    //    //Console.Write("Задайте шаг уровня: ");
    //    //double step = double.Parse(Console.ReadLine());
    //    //int Count = 0;


    //    //while ((upPrice - step) >= downPrice)
    //    //{

    //    //    Count++;
    //    //    upPrice -= step;
    //    //    Console.WriteLine("{0:f1}", upPrice);
    //    //}
    //    //Console.WriteLine($"Колличество уровней: "+ Count);


    //}


}

        
    
