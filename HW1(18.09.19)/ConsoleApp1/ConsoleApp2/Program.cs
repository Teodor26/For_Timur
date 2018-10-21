using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] Array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                   Array[i, j] = rnd.Next(10);
                   if (Array[i, j]>=0 & Array[i, j]<=2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("█");                        
                    }
                    
                    else if (Array[i, j] >= 3 & Array[i, j] <= 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("█");
                        
                    }
                    else if (Array[i, j] >= 6 & Array[i, j] <= 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("█");
                        
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("█");
                        
                    }
                }
                Console.WriteLine();
            }
         Console.ReadKey();
        }
    }
}
