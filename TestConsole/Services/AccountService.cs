using System;
using System.Collections.Generic;
using TestConsole.Services.Entities;
using TestConsole.Services.Interfaces;

namespace TestConsole
{
    public class AccountService : IAccountService
    {
        private decimal _balance;
        private readonly IPrintService _printService;
        private readonly List<Operation> _operationHistory = new();

        public AccountService(IPrintService printService)
        {
            _printService = printService;
        }

        public void Deposit(Amount amount)
        {
            _balance += amount.Value;

            _operationHistory.Add(new Operation()
            {
                Balance = _balance,
                Created = DateTime.Now,
                Amount = amount.Value
            });
        }

        public void Withdraw(Amount amount)
        {
            if (_balance < amount.Value)
                throw new Exception($"Imposible to withdraw {amount.Value} from {_balance}");

            _balance -= amount.Value;

            _operationHistory.Add(new Operation()
            {
                Balance = _balance,
                Created = DateTime.Now,
                Amount = -1 * amount.Value
            });
        }

        public void PrintStatement()
        {
            _printService.Print(_operationHistory);
        }
    }
}
