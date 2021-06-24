using System;
using TestConsole.Services.Interfaces;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPrintService printService = new ConsolePrintService();
            IAccountService accountService = new AccountService(printService);

            accountService.Deposit(new Amount() { Value = 1000 });
            accountService.Deposit(new Amount() { Value = 2000 });
            accountService.Withdraw(new Amount() { Value = 500 });

            accountService.PrintStatement();
        }
    }
}
