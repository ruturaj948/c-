using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum(int num)
            {
                int nsum = 0,m;
                while (num > 0)
                {
                    m = num % 10;
                    nsum = nsum + m;
                    num = num / 10;
                }
                return nsum;
            }
            Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of number is " + sum(number));
            Console.ReadLine();


        }
    }
}
