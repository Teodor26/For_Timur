using System;


namespace Information.BussinesLogic
{
    public class Person
    {
        public string[] login = new string[20];
        public string[] password = new string[20];
        public string[] banlist = new string[20];
        public int[] balance = new int[20];
        public int TempBalance = 0;
        public bool Anotherfinish=true;
        int gotobanlist = 3;

        public void Checkout(string Login,ref bool checkpass)
        {
            for (int i = 1; i < login.Length; i++)
            {
                 if (banlist[i] == Login)
                {
                    Console.WriteLine("You are banned. Please ask the administrator to unbann you.");
                    Console.ReadLine();
                    break;
                }
                else if (Login == "admin")
                {
                   continue;
                }
                else if ( Login !="admin")
                {

                    if(login[i] == Login)
                    {
                        Console.WriteLine("You have already had an account.");
                        break;
                    }
                    if(i == login.Length-1)
                    {
                        checkpass = false;
                        Console.WriteLine("You have not got an account.\nYou password will be the same as login.");
                        Console.ReadLine();
                        password[i] = login[i];
                    }

                }     
                
               
            }
        }         
                
            
        

        public void Input(string Login, string Password)
        {
            if (Login == "" & Password == "")
            {
                Console.WriteLine("Try again.");
            }

            else if (Login == "admin" && Password == "admin")
            {
                AdminMenu();
            }

            else if (Login != null && Password != null)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] == Login  &&  password[i] == Password )
                    {
                        TempBalance = i;
                        //Console.WriteLine($"Hello {login[i]}. You are in the system");         
                        ForClient();
                        
                    }
                    
                }
                for (int i = 0; i < login.Length; i++)
                {
                    if(password[i] != Password && login[i] == Login)
                    {
                        gotobanlist--;
                        
                        Console.WriteLine($"You have {gotobanlist} tries or you will be blocked.");
                        Console.ReadLine();
                        if (gotobanlist==0)
                        {
                            Console.WriteLine("You are blocked. Ask an administator to unban you.");
                            Console.ReadLine();
                            banlist[i] = login[i];
                            login[i] = null;
                        }
                    }
                }

            }
        }

        public void Balance()
        {
            for (int i = 0; i < balance.Length; i++)
            {
                balance[i] = 100;
            }

        }

        public void ForClient()
        {
            Anotherfinish = true;
            while (Anotherfinish)
            {
                Console.Clear();
                Console.WriteLine("You are in the system.");
                Console.WriteLine($"See your balance - {1}");
                Console.WriteLine($"Withdraw money - {2}");
                Console.WriteLine($"Put money into your account - {3}");
                Console.WriteLine($"Log out - {4}");
                Int32.TryParse(Console.ReadLine(), out int choise);
                switch (choise)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("This is your balance");
                        for (int i = 1; i < balance.Length; i++)
                        {
                            if (TempBalance == i)
                            {
                                Console.Write($"{balance[TempBalance]}$");
                               
                                break;
                            }
                        }
                        Console.ReadLine();
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("Tipe the amount of money which you want to withdraw");
                        Int32.TryParse(Console.ReadLine(), out int NewBalance);
                        for (int i = 0; i < balance.Length; i++)
                        {
                            if (TempBalance == i)
                            {
                                balance[TempBalance] = balance[TempBalance] - NewBalance;
                                if(balance[TempBalance]<0)
                                {
                                    balance[TempBalance] = balance[TempBalance] + NewBalance;
                                    Console.WriteLine("You cannot withdraw this amount of money.Try again");
                                    Console.ReadLine();
                                    
                                }
                            }

                        }

                        
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tipe the amount of money which you want to put");
                        Int32.TryParse(Console.ReadLine(), out int NewBalance1);
                        for (int i = 0; i < balance.Length; i++)
                        {
                            if (TempBalance == i)
                            {
                                balance[TempBalance] = balance[TempBalance] + NewBalance1;
                            }
                        }


                        break;

                    case 4:

                        Anotherfinish = false;
                        break;
                }

            }
        }
        
        public void AdminMenu()
        {
            Anotherfinish = true;
            while (Anotherfinish)
            {
                Console.Clear();
                Console.WriteLine("Hello, administrator!");
                Console.WriteLine($"Press {1} to show all users`s list");
                Console.WriteLine($"Press {2} to add new users");
                Console.WriteLine($"Press {3} to delete users");
                Console.WriteLine($"Press {4} to show ban list and unban the users.");
                Console.WriteLine($"Press {5} to log out");
                Int32.TryParse(Console.ReadLine(), out int Choise);

                switch (Choise)
                {

                    case 1:
                        Console.Clear();
                        for (int i = 1; i < login.Length; i++)
                        {
                            if (login[i] != null)
                            {
                                Console.WriteLine($"{i}. " + login[i]);

                            }
                            else
                            {
                                break;
                            }
                        }
                        Console.ReadLine();
                        break;


                    case 2:
                        Console.Clear();
                        Console.WriteLine("Input a new client");
                        for (int i = 0; i < login.Length; i++)
                        {

                            if (login[i] == null)
                            {
                                login[i] = Console.ReadLine();
                                password[i] = login[i];
                                break;

                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("What client do you want to delete:");
                        for (int i = 1; i < login.Length; i++)
                        {
                            if (login[i] != null)
                            {
                                Console.WriteLine($"{i}. " + login[i]);
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.Write("Input the login: ");

                        string NewClient = Console.ReadLine();
                        for (int i = 0; i < login.Length; i++)
                        {
                            if (login[i] == NewClient)
                            {
                                banlist[i] = login[i];
                                login[i] = "This client was deleted";
                            }

                        }

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ban List:");
                        for (int i = 0; i < banlist.Length; i++)
                        {

                            if (banlist[i] != null)
                            {
                                Console.WriteLine($"{i}. " + banlist[i]);
                            }
                            else
                            {
                                continue;
                            }

                        }

                        Console.Write("What client do you want to unban. Tipe the login: ");
                        string unban = Console.ReadLine();
                        for (int i = 0; i < login.Length; i++)
                        {
                            if (banlist[i] == unban)
                            {
                                login[i] = unban;
                                banlist[i] = null;
                            }
                        }
                        break;


                       case 5:

                        Console.WriteLine("Bye.");
                        Console.ReadLine();
                        Anotherfinish = false;
                        break;
                }
                
            }
           
        }
            
        

        



    }
}
