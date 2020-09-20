namespace DesignPatterns.Factory
{
    public interface IPaymentCard
    {
         string GetName();
         string GetProviderInfo();
    }

    public class VisaCard : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProviderInfo()
        {
            return "Visa";
        }
    }

    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProviderInfo()
        {
            return "MasterCard";
        }
    }
}

