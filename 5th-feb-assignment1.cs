using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{
    class Classas1
    {
        static void Main(string[] args)
        {
            //2. program to add three numbers
            int x = 5,y=10,z=10,id=101,salary=25000;
            string name="Ajay",address="ABC,Delhi";
            int add = x + y + z;
            int multiply = x * y * z;
           
            Console.WriteLine(add);
            //3.program to multiply three numbers
            Console.WriteLine(multiply);

            //4.what is system in the program .what is console?what are write,writeLine?
            //#The system is a root name space for built-in-types provided by Microsoft.Net Framework.
            //#console is a class in that namespace.
            //#write() method displays the output but do not provide a new line character.
            //#writeLine() method displays the output and also provides a new line character at the end of the string.
            
            //5.Is it mandatory to have a class in the project?
            //#yes,c#  application must have at least one class with main method ,so that execution can begin from it.
            
            //6.program to declare string string and integer variablesto hold id, name, address,salary and display it.

           Console.WriteLine("welcome" +" " + name+ ", your details are as follows:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your ID:"+id);
     
            salary = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your address is:" +address );
            Console.WriteLine("Your salary is:"+salary);
        }
    }
}
