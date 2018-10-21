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
                string Input = "18fdas99dsfadf88sfsdg9gffd11dfsgsd11fda6";
                string ArrayData = "1234567890";
                int Sum = 0;
                char[] CharInput = Input.ToCharArray();
                char[] CharArrayData = ArrayData.ToCharArray();
                char[] CharResult = new char[CharInput.Length];
                string Amount = "";
               

                Console.WriteLine("Incoming string :" + Input);
                Console.Write("All numbers in the string: ");

            for (int i = 0; i < CharResult.Length; i++)
            {
                for (int j = 0; j < CharArrayData.Length; j++)
                {
                    if (CharInput[i] == CharArrayData[j])
                    {
                        CharResult[i] = CharInput[i];

                    }

                }
                Console.Write(CharResult[i]);
            }
            

            for (int i = 0; i < CharInput.Length; i++)
                {
                    if (CharArrayData.Contains(CharInput[i]))
                    {

                    Amount += CharInput[i];
                      
                    }
                    else
                    {
                        if (Amount != "")
                        {
                            
                            Sum += Int32.Parse(Amount);
                            
                        Amount = "";
                        }
                    }

                }
                
                if (Amount != "")
                {
                   
                   Sum += Int32.Parse(Amount);
                }
                Console.WriteLine();
                Console.Write($"The sum of all numbers in the string: {Sum}");
                Console.ReadLine();
            }
        }
     }