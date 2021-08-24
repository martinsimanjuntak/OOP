using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Product product = new Product();
            Employee customer = new Employee();
                Console.WriteLine("pilihan anda : ");
                while (true)
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("1. Create User");
                    Console.WriteLine("2. Show User");
                    Console.WriteLine("3. Search");
                    Console.WriteLine("4. Login");
                    Console.WriteLine("5. Keluar");
                    Console.WriteLine("=======================");


                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choice == 1)
                        {
                            customer.register();
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            customer.show();
                            
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            customer.show();

                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Masukkan Username \t");
                            string username = Console.ReadLine();

                            Console.WriteLine("Masukkan Password");
                            string password = Console.ReadLine();
                            customer.login(username,password);
                        }
                        else
                        {
                            break;
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Silahkan masukkan angka");
                    }

                }
            }
            

        }

       
    
}
