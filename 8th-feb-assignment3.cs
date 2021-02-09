﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modularity1
{
    class class_program2
    {
        static void Main()
        {

            //1. Write a program in C# Sharp to count a total number of duplicate elements in an arrayusing System;


            int[] num = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The total number of duplicate elements in the array is " + count);



            /*2. WAP to find the eligibility of admission for a professional course based on the following criteria:
            Marks in Maths >=65
            Marks in Phy >=55
            Marks in Chem>=50
            Total in all three subject >=180
            or
            Total in Math and Phy>=140

            Test Data :
            Input the marks obtained in Physics :65
            Input the marks obtained in Chemistry :51
            Input the marks obtained in Mathematics :72
            Expected Output :
            The candidate is eligible for admission.*/

            int maths, phy, chem, total_3, total_math_phy;
            Console.Write("Input the marks obtained in Physics :");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            maths = Convert.ToInt32(Console.ReadLine());
            total_3 = maths + phy + chem;
            total_math_phy = maths + phy;

            if ((maths >= 65) && (phy >= 55) && (chem >= 50))
            {
                if ((total_3 >= 180) || (total_math_phy >= 140))
                    Console.WriteLine("\nThe candidate is eligible for admission.");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission.");



            /*3. Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow :

            Unit                               Charge/unit
            upto 199                        @1.20
            200 and above but less than 400        @1.50
            400 and above but less than 600        @1.80
            600 and above                        @2.00

            If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be of Rs. 100/-

            Test Data :
            1001
            James
            800
            Expected Output :
            Customer IDNO :1001
            Customer Name :James
            unit Consumed :800
            Amount Charges @Rs. 2.00 per unit : 1600.00
            Surchage Amount : 240.00
            Net Amount Paid By the Customer : 1840.00*/


            string custID, custName;
            double units, charges = 0, surchage = 0, net_amt;
            Console.Write("Customer IDNO :");
            custID = Console.ReadLine();
            Console.Write("Customer Name :");
            custName = Console.ReadLine();
            Console.Write("unit Consumed :");
            units = Convert.ToDouble(Console.ReadLine());

            if (units <= 199)
            {
                charges = units * 1.20;
                Console.WriteLine("\nAmount Charges @Rs. 1.20 per unit : {0:N2}", charges);
            }
            else if (units >= 200 && units <= 400)
            {
                charges = units * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : {0:N2}", charges);
            }
            else if (units >= 400 && units <= 600)
            {
                charges = units * 1.80;
            }
        }
    }
}

