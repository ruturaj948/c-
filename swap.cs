using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter value of variable: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of variable list :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = "+a+" b = "+b);
            a = a + b;
            b = a-b;
            a = a - b;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadLine();
        }
    }
}
