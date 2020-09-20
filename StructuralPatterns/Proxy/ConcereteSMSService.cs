
namespace DesignPatterns.StructuralPatterns
{
    public class ConcereteSMSService : SMSService
    {
        public override string SendSMS(string custId, string mobile, string sms)
        {
            return $"CustomerId {custId}, sms sent to {mobile}";
        }
    }
}