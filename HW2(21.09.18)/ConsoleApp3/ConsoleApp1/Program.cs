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

                int[,] matrix = GenerateMatrix(5, 5, 10);
                DrawMatrix(matrix);

                int even = 0;
                int odd = 0;
                int even1 = 0;
                int odd1 = 0;
                for (int x = 0; x < 5; x++)
                {
                    for (int z = 0; z < 5; z++)
                    {
                        if (matrix[x, z] % 2 == 0)
                        {
                            even1 = even1 + matrix[x, z];
                        }
                        else
                        {
                            odd1 = odd1 + matrix[x, z];
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("even:" + even1);
                Console.WriteLine("odd: " + odd1);
                Console.WriteLine();
                int[] matrix1 = Matrix(5, 5);

                for (int i = 0; i < matrix1.Length; i++)
                {
                    if (matrix1[i] % 2 == 0)
                    {
                        even = even + matrix1[i];
                    }
                    else
                    {
                        odd = odd + matrix1[i];
                    }

                }
                Console.WriteLine();
                Console.WriteLine("even:" + even);
                Console.WriteLine("odd: " + odd);
                Console.ReadKey();

            }


            public static int[,] GenerateMatrix(int x, int y, int maxRandom)
            {
                int[,] matrix = new int[x, y];

                Random rnd = new Random();

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        matrix[i, j] = rnd.Next(0, maxRandom);
                    }
                }

                return matrix;
            }

            public static void DrawMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{(matrix[i, j].ToString().Length < 2 ? matrix[i, j].ToString() + "  |" : matrix[i, j].ToString() + " |")}");
                    }
                    Console.WriteLine();
                }
            }

            public static int[] Matrix(int x, int maxRandom)
            {
                int[] matrix1 = new int[x];

                Random rnd = new Random();

                for (int i = 0; i < x; i++)
                {
                    matrix1[i] = rnd.Next(0, maxRandom);
                    Console.Write(matrix1[i] + "|  ");

                }

                return matrix1;
            }
        }
    }
