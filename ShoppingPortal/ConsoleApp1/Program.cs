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

                var response = false;//bool
                var name = "";//string
                var carmodel="";// string
                var check = 'Y';// char
                var totnumber = 0; //int
                var price = 0.0;//double
                var totalprice = 0.0m;//decimal

            Console.WriteLine(" **Welcome to the Online Old Cars Marketing**");
            Console.WriteLine(" \n Please enter your name  ");
            name = Console.ReadLine();
            Console.WriteLine($"\n **Welcome ' { name } ' on Online Old Cars Marketing**" );
            Console.WriteLine("\n Are  you looking for Buying a Car? REPLY true/false");
             response = Boolean.Parse(Console.ReadLine());
            if (response == true)
            {

              
                while (check != 'N')
                {
                    Console.WriteLine("\n -> What is the Model's name? ");
                    carmodel = Console.ReadLine();
                    Console.WriteLine("\n **Checking for the availability of Car Model**");

                     switch (carmodel)
                    {
                        case "Hundai":
                            Console.WriteLine("\n ->Yes Hundai is in the list");
                            Console.WriteLine("\n How many Cars do you want to buy?");
                            totnumber = Int32.Parse(Console.ReadLine());
                            price = 5000.50;
                            Console.WriteLine($"The price of the car is {price}");
                            totalprice = totnumber * (decimal)price;
                            Console.WriteLine($"----------------------------------");
                            Console.WriteLine($"The final price of the car is {totalprice}");
                            Console.WriteLine($"----------------------------------");
                            check='N';
                          
                            break;

                        case "Chrysler":
                            Console.WriteLine("\n ->Yes Chrysler in the list");
                            Console.WriteLine("How many Cars do you want to buy?");
                            totnumber = Int32.Parse(Console.ReadLine());
                            price = 6006.98;
                            Console.WriteLine($"The price of the car is {price}");
                            totalprice = totnumber * (decimal)price;
                            Console.WriteLine($"----------------------------------");
                            Console.WriteLine($"The final price of the car is {totalprice}");
                            Console.WriteLine($"----------------------------------");
                            check = 'N';
                          
                            break;

                        case "Kia":
                            Console.WriteLine("\n ->Yes Kia in the list");
                            Console.WriteLine("How many Cars do you want to buy?");
                            totnumber = Int32.Parse(Console.ReadLine());
                            price = 9786.76;
                            Console.WriteLine($"The price of the car is {price}");
                            totalprice = totnumber * (decimal)price;
                            Console.WriteLine($"----------------------------------");
                            Console.WriteLine($"The final price of the car is {totalprice}");
                            Console.WriteLine($"----------------------------------");
                            check = 'N';
                          
                            break;

                        case "Mitsubishi":
                            Console.WriteLine("\n ->Yes Mitsubishi  in the list");
                            Console.WriteLine("How many Cars do you want to buy?");
                            totnumber = Int32.Parse(Console.ReadLine());
                            price = 7678.87;
                            Console.WriteLine($"The price of the car is {price}");
                            totalprice = totnumber * (decimal)price;
                            Console.WriteLine($"----------------------------------");
                            Console.WriteLine($"The final price of the car is {totalprice}");
                            Console.WriteLine($"----------------------------------");
                            check = 'N';
                           
                            break;

                        default:
                            Console.WriteLine("Not in the list");
                            Console.WriteLine("Would you like to try other Models? REPLY Y/N");
                            check = Char.Parse(Console.ReadLine());
                            break;
                    }
                    
                }

                Console.WriteLine("\n Thank you for shopping !!");
               


            }
            else {

                Console.WriteLine("Try looking for other sites for new cars");

            }
            


            Console.ReadLine();

        }
    }
}
