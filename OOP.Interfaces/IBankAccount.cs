namespace OOP.Interfaces
{
    public interface IBankAccount // interfacelerin başında I ifadesi kullanılır
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }
}