using System;

namespace ATM
{
    class Bank
    {
        String name;
        int accno;
        string type;
        long bal;
        public Bank(String n, int a, String t, long b)
        {
            name = n;
            accno = a;
            type = t;
            bal = b;
        }
        public void deposit(int a)
        {
            bal = bal + a;
        }
        public void widthdraw(int w)
        {
            if (w <= bal)
            {
                bal = bal - w;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public void display()
        {
            Console.WriteLine("Account No." + accno);
            Console.WriteLine("Account Holder Name " + name);
            Console.WriteLine("Account type" + type);
            Console.WriteLine("Account Balance" + bal);

        }
    }
    class ATM
    {
        static void Main(string[] args)
        {

            int ch;
            Bank b = new Bank("Raj", 1001, "canara Bank", 0);

            do
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Widthdraw");
                Console.WriteLine("3.Display Details");
                Console.WriteLine("4.Exit");
                Console.WriteLine("********************");
                Console.Write("Enter choice from above menu 1,2,3,4,0");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Dposit Amount");
                        int amount = int.Parse(Console.ReadLine());
                        b.deposit(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter Widthdrawal Amount");
                        int wamount = int.Parse(Console.ReadLine());
                        b.deposit(wamount);
                        break;
                    case 3:
                        Console.WriteLine("Enter Holders Details");
                        b.display();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

            } while (ch < 4);


        }
    }
}
