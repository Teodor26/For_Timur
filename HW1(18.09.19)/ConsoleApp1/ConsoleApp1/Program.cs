using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Again = 0;
            int[] Array = {5, -8, -1, 0, 9, 12, 3, 20, 6,-18};
           
            Console.Write("Incoming array: ");
            for (int x= 0; x < Array.Length; x++)
            {
                Console.Write(Array[x] + " ");
            }
            Console.WriteLine();
            while (Again < 9)
            {
                for (int i = 0; i < Array.Length - 1; i++)

                {
                    {
                        if (Array[i] > Array[i + 1])
                        {
                            int c = Array[i];
                            Array[i] = Array[i + 1];
                            Array[i + 1] = c;
                        }
                        else
                        {
                            Array[i] = Array[i];
                        }

                    }
                }
                Again++;
            }
            Console.Write("Sorted array:");
            for (int j = 0; j < Array.Length; j++)
                {
                    Console.Write(Array[j] + " ");
                }
            
            Console.ReadLine();
        }
           
    }
        
}
   


