using System;
namespace Bank
{
    class Bank
    {
        public string name;
        public int balance;
        public Bank(string Name , int Balance)
        {
            name = Name;
            balance = Balance;
        }

        public string getName()
        {
           Console.Write("Enter account holder's name : ");
           string name = Console.ReadLine();
           return name;
        }

         public int getBalance()
        {
            Console.Write("Enter Balance : ");
            int balance = Convert.ToInt32(Console.ReadLine());
            return balance;
        }
       
        static void Main(string[] args)
        {
            Bank b = new Bank("" , 30000);
            Console.WriteLine("Account Name = " + b.getName());
            Console.WriteLine("Balance = " + b.getBalance());
        }
    }
}