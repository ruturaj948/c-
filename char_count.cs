using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            String str = Console.ReadLine();
            int characters = 0;
            int numbers = 0;
            int schar = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')) characters++;

                else if (str[i] <= '0' && str[i] >= '9') numbers++;
                else schar++;
            }
            Console.WriteLine("characters = " + characters);
            Console.WriteLine("numbers = " + numbers);
            Console.WriteLine("schar = " + schar);
            Console.ReadLine();
        }
    }
}

