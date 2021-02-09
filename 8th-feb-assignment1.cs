using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modularity1
{
    class overloading
    {
       
            static void Add(int x, int y)
            {
                Console.WriteLine("Result of sum is " + (x + y));
            }

            static void Subtract(int x, int y)
            {
                Console.WriteLine("Result of subtraction is " + (x - y));
            }

            static void Product(int x, int y)
            {
                Console.WriteLine("Result of product is " + (x * y));
            }

            static void Divide(int x, int y)
            {
                Console.WriteLine("Result of division is " + (x / y));
            }
            static void Main()
            {
                //1.using if else
                Console.WriteLine("enter value of x");
               
                int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Add(x, y);
                }
                else if (choice == 2)
                {
                    Subtract(x, y);
                }
                else if (choice == 3)
                {
                    Product(x, y);
                }
                else if (choice == 4)
                {
                    Divide(x, y);
                }
                else
                    Console.WriteLine("Invalid choice");


                //2.using switch
                Console.WriteLine("enter value of n1");
          
                int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of n2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your choice");
            int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Add(n1, n2);
                        break;
                    case 2:
                        Subtract(n1, n2);
                        break;
                    case 3:
                        Product(n1, n2);
                        break;
                    case 4:
                        Divide(n1, n2);
                        break;
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }




