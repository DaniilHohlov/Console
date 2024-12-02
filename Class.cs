//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;


//namespace MyConsole
//{
//    public class TimerManager
//    {   
        
//        private static void Timer_Elapsed(object sender)
//        {
//            Random random = new Random();

//            int num = random.Next(-10, 10);
//            TradeDirection direction;
//            if (num > 0)
//            {
//                direction = TradeDirection.Long;
//            }
//            else
//            {
//                direction = TradeDirection.Short;
//            }
//            int newPrice = random.Next(70000, 80000);
//            TradeManager manager = new TradeManager();
//            Trade trade = new Trade(direction, pair, Math.Abs(num), newPrice, random.Next(1, 5), newPrice);
//            manager.WriteTradeToFile(trade);


//        }
//    }
//}
