using System;
using System.Collections.Generic;
using System.Text;

namespace ass2
{
    class Classas
    {
        static void Main(string[] args)
        {
            int x, y, z, add, sum = 0, avg = 0, num, t, type, count = 0;
            //2.program to add three numbers
            Console.WriteLine("Enter num 1");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num 3");
            z = Convert.ToInt16(Console.ReadLine());
            add = x + y + z;
            Console.WriteLine("sum of x+y+z is" + " " + add);
            //3.program to print sum and average of first 20 numbers
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
                avg = sum / 20;
            }
            Console.WriteLine("sum  and avg of 20 natural numbers is " + sum + "and" + "" + avg);

            //4.program to print first 50 even numbers
            Console.WriteLine("even numbers are:");
            for (int even = 2; even < 50; even += 2)
            {
                Console.WriteLine(even);
            }
            //5.program to check whether a number is prime or not
            Console.WriteLine("Enter num");
            int prime;
            num = Convert.ToInt16(Console.ReadLine());
            for (prime = 2; prime < num; prime++)
            {
                if (num % prime == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine(" {0} is a prime number", prime);
            }
            else
            {
                Console.WriteLine("{0}is not a prime number", prime);
            }

            //6.program to print table of entered number
            Console.WriteLine("enter a number");
            t = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= 2; j++)
            {
                int k = t * j;

                Console.WriteLine("{0}*{1}={2}", t, j, k);
            }
            //7.program to take some numbers from user and note difference between ToInt16,ToInt32 and other methods
            Console.WriteLine("Enter num");
            int n1, n2;
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine("Enter num");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n2);
            Console.WriteLine(Convert.ToByte(n2));

        }
    }
}

    //8.what is system in the program.what is console? what are write, writeLine?
    //#The system is a root name space for built-in-types provided by Microsoft.Net Framework.
    //#console is a class in that namespace.
    //#write() method displays the output but do not provide a new line character.
    //#writeLine() method displays the output and also provides a new line character at the end of the string.
    //#convert is used to convert one data type to other data type
    //#read line is a input statement to take values
    //#toByte is used to convert data into bytes

    //9.Is it mandatory to have a class in the project?
    //#yes,c#  application must have at least one class with main method ,so that execution can begin from it.

    //10.why is static added to Main() method?
    //A Main method is static since it is available when run the c# program starts.it is the entry point of the program and runs without even creating an instance of the class.

