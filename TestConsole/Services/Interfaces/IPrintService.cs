using System.Collections.Generic;
using TestConsole.Services.Entities;

namespace TestConsole.Services.Interfaces
{
    public interface IPrintService
    {
        void Print(List<Operation> operationHistory);
    }
}
