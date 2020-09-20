namespace DesignPatterns.Factory
{
    public interface IBankFactory
    {
        IBank GetBank(string bankCode);
        IPaymentCard GetPaymentCard(string cardNumber);
        
    }
}