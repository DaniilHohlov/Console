using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{

    public class Program
    {
            static void Main(string[] args)
            {
                Position position = new Position();
                position.PositionChanged += Position_PositionChanged;

                Console.WriteLine("Ожидайте изменения позиции...");
                Console.ReadLine();
            }
            private static void Position_PositionChanged()
            {
                // Выводим сообщение при изменении позиции
                Console.WriteLine("Позиция изменилась\n");
            }

    }
}

        
    
