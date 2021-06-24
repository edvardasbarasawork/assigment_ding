using System;
using System.Collections.Generic;
using System.Linq;
using TestConsole.Services.Entities;

namespace TestConsole.Services.Interfaces
{
    public class ConsolePrintService : IPrintService
    {
        public void Print(List<Operation> operationHistory)
        {
            Console.WriteLine("Date || Amount || Balance");

            if (operationHistory != null && operationHistory.Any())
            {
                foreach(var operation in operationHistory.OrderByDescending(i => i.Created))
                {
                    Console.WriteLine($"{operation.Created.ToShortDateString()} || {operation.Amount} || {operation.Balance}");
                }
            }
        }
    }
}
