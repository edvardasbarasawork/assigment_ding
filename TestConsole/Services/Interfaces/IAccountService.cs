namespace TestConsole
{
    public interface IAccountService
    {
        void Deposit(Amount amount);

        void Withdraw(Amount amount);

        void PrintStatement();
    }
}
