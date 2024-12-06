using System;
using System.IO;



namespace MyConsole
{
    public class TradeManager
    {

        public void WriteTradeToFile(Trade trade)
        {
            
            string filePath = @"C:\Users\user\source\repos\Console\TradeInfo.txt";
            using (StreamWriter stream = new StreamWriter(filePath, true))
            {
                stream.WriteLine($"Направление: {trade.Direction}");
                stream.WriteLine($"Валюта: {trade.Pair}");
                stream.WriteLine($"Объем: {trade.Volume}");
                stream.WriteLine($"Цена входа: {trade.Price}");
                stream.WriteLine($"Количество открытых лотов: {trade.OpenLotsCount}");
                stream.WriteLine($"Цена выхода: {trade.TakeProfit}");
                stream.WriteLine($"Стоп Лосс: {trade.StopLoss}");
                stream.WriteLine($"Время создания: {DateTime.Now}");
            }

            Console.WriteLine($"Данные сделки успешно сохранены в файл: {filePath}\n"); 
        }
        
    }
}
