using System;
using Information.BussinesLogic;

namespace FinallATM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person client = new Person();
            client.login[0] = "admin";
            client.password[0] = "admin";
            bool inadmin = true;
            client.login[1] = "Alex";
            client.password[1] = "Alex";
            client.Balance();
            bool finish = true;

            bool checkpass = true;
            while (finish)
            {

                Console.Clear();
                Console.WriteLine($"Hello client.\nPress {1} to enter the system or press {2} to log out");

                Int32.TryParse(Console.ReadLine(), out int a);

                if(a==1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the login");
                    string Inputlogin = Console.ReadLine();
                    client.Checkout(Inputlogin,ref checkpass);
                    if (checkpass == true)
                    {
                        Console.WriteLine("Enter your password ");
                        string InputPassword = Console.ReadLine();
                        client.Input(Inputlogin, InputPassword);
                    }
                    else if(Inputlogin!="admin")
                    {
                        client.ForClient();
                    }
                    else
                    {
                        while(inadmin)
                        {
                            Console.WriteLine("Enter your password ");
                            string Admchek = Console.ReadLine();
                            if (Admchek == "admin")
                            {
                                inadmin = false;
                                client.AdminMenu();
                            }
                        }
                        
                       
                    }
                    // Console.ReadLine();
                }

                if (a == 2)
                {
                    finish = false;
                }
            }

            
        }
    }
}
