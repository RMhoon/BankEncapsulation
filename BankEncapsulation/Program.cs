using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankacct = new BankAccount();

            Console.WriteLine("How much money are you depositing today?");
            var deposit = double.Parse(Console.ReadLine());
            bankacct.Deposit(deposit);

            Console.WriteLine($"Thank you for your deposit.  Your balance is ${bankacct.GetBalance():#,##0}");
        }
    }
}
