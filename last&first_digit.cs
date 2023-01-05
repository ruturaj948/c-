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
            int num, last;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            last = num % 10;
            Console.WriteLine("The last number of digit is :"+last);
            while (num >= 10)
            {
                num = num / 10;
            }
            Console.WriteLine("The first number of digit is :" + num);
            Console.ReadLine();
        }
    }
}
