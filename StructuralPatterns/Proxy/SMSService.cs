namespace DesignPatterns.StructuralPatterns
{
    public abstract class SMSService
    {
        public abstract string SendSMS(string custId,string mobile, string sms);
        
    }
}