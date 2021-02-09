
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeee
{
    class Employee
    {
        /*1.Create a class Employee with following attributes
  Empid
  Name
  dept
  Manager
  Basic Salary
  Exp

  Depending upon Exp, calculate Net Salary
if exp > 10 years , DA = 10 % of basic, HRA = 8.5 % of basic , PF = 6200
if exp > 7 years and less than 10 years , DA = 7 % of basic, HRA = 6.5 % of basic , PF = 4100
if exp > 5 years and less than 7 years, DA = 4.1 % of basic, HRA = 3.8 % of basic , PF = 1800
if exp< 10 years, DA = 1.9 % of basic, HRA = 2.0 % of basic, PF = 1200

Display the details in proper way

 You are supposed to do it for 5  Employees*/

        int Empid,exp;
        string Name,dept,manager;
    
        double Basicsalary, DA, HRA, PF, netsalary;
      
        public void GetDetails()
        {
            Console.WriteLine("Enter employee id");
            Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter basic salary");
            Basicsalary= Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter experience of employee");
            exp = Convert.ToByte(Console.ReadLine());
        }
        public void Calculate()
        {
            if (exp > 10)
            {
                DA = (Basicsalary * 10 )/ 100;
                HRA = (Basicsalary * 8.5) / 100;
                PF = 6200;
               

            }
            else if ((exp > 7) && (exp < 10))
            {
                DA = (Basicsalary * 7 )/ 100;
                HRA = (Basicsalary * 6.5) / 100;
                PF = 4100;
                
            }
            else if ((exp > 5) && (exp < 7))
            {
                DA = (Basicsalary * 4.1) / 100;
                HRA = (Basicsalary * 3.8) / 100;
                PF = 1800;
                
            }
            else if (exp < 10)
            {
                DA = (Basicsalary * 1.9 )/ 100;
                HRA = (Basicsalary * 2.0) / 100;
                PF = 1200;
                
            }
            netsalary = (Basicsalary + DA + HRA) - PF;

        }
        public void DisplayDetails()
        {

        
            Console.WriteLine("employee  id is " + Empid);
            Console.WriteLine(" employee name  is " +Name );
            Console.WriteLine("employee department is " +dept);
            Console.WriteLine(" employee manager is " + manager);
            Console.WriteLine("employee basic salary is " + Basicsalary);
            Console.WriteLine("DA is " + DA);
            Console.WriteLine("HRA is " + HRA);
            Console.WriteLine("PF is " + PF);
            Console.WriteLine("employee net salary  is " + netsalary);


        }



        class Program
        {
            static void Main(string[] args)
            {
                /* Employee employee1 = new Employee();
                 employee1.GetDetails();
                 employee1.DisplayDetails();
                 Employee employee2 = new Employee();
                 employee2.GetDetails();
                 employee2.DisplayDetails();
                 Employee employee3 = new Employee();
                 employee3.GetDetails();
                 employee3.DisplayDetails();
                 Employee employee4 = new Employee();
                 employee4.GetDetails();
                 employee4.DisplayDetails();
                 Employee employee5 = new Employee();
                 employee5.GetDetails();
                 employee5.DisplayDetails();*/


                List<Employee> list = new List<Employee>();
                Employee employee1 = new Employee();
                list.Add(employee1);
                Employee employee2 = new Employee();
                list.Add(employee2);
                Employee employee3= new Employee();
                list.Add(employee3);
                Employee employee4 = new Employee();
                list.Add(employee4);
                Employee employee5 = new Employee();
                list.Add(employee5);
                foreach(Employee emp in list)
                {
                    emp.GetDetails();
                    emp.Calculate();
                    emp.DisplayDetails();

                }
            }
        }
    }
}
