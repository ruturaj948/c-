using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = new int[2];
                Console.WriteLine("Enter two numers");
                num[0] = int.Parse(Console.ReadLine());
                num[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Division " + (num[0] / num[1));
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error is :"+e);
            }
        }
    }
}
