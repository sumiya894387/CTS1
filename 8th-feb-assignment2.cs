using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modularity1
{
    class Program
    {
        static void Main(string[] args)
        {
          //1.    print sum and average of elements of array
            int[] arr = new int[10];
            float sum = 0;
            float avg;
            int i, j;
            int[] sum2 = new int[2];
            int[] sum3 = new int[2];
            int[,] num1 = new int[2, 2];
            Console.WriteLine("enter numbers");
            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToByte(Console.ReadLine());
                sum += arr[i];
            }
            avg = sum / 10;
            Console.WriteLine("sum is" + " " + sum + " " + "and avg is" + " " + avg);
           //2.program to display sum of 3 by 3 matrices

            int sum1 = 0;
            int[,] arr1 = new int[3, 3];
            Console.WriteLine("enter numbers for 3 by 3 matrix");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum1 += arr1[i, j];
                }
            }
            Console.WriteLine("sum is" + " " + sum);

             //3.program to find maximum element of an integer array

            Console.WriteLine("enter numbers");
            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = arr[0];
            for (i = 0; i < 10; i++)
            {
                
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("maximum element is" + " " + max);
            //4.program to print column wise sum of elements of 2d array
         
            Console.WriteLine("enter numbers to print column wise sum of elements");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" numbers to print column wise sum of elements are");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(num1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of columns");
            
            for (i = 0; i < 3; i++)
            {
                sum2[i] = 0;
                for (j = 0; j < 3; j++)
                {

                    sum2[i] += num1[j, i];
                }
                
            }
            for (j = 0; j < 2; j++)
            {
                Console.WriteLine(sum2[j]);
            }
            //5.PROGRAM TO PRINT ROW WISE SUM OF ELEMENTS
           
            Console.WriteLine("enter numbers to print ROW wise sum of elements");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" numbers to print ROW wise sum of elements are");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(num1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of ROWS");
            for (i = 0; i < 2; i++)
            {
                sum3[i] = 0;

                for (j = 0; j < 2; j++)
                {

                    sum3[i] += num1[i, j];
                }
                
            }
           
            
            for (i = 0; i < 2; i++)
            {

            }
            for (j = 0; j < 2; j++)
            {
                Console.WriteLine(sum3[i]);
            }
        }
    }

}

