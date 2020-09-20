using System;
using System.Text;

namespace DesignPatterns.StructuralPatterns
{
    public class NotificationEmailDecorator:AbstractDecorator
    {
        public string SmsSentNotification(string custId,  string sms){
              return $"sms {sms}, sent to {custId}, at {DateTime.Now.ToLongDateString()}";
        }

        public override string SendSMS(string custId, string mobile, string sms)
        {
            StringBuilder result = new StringBuilder ();
            result.AppendLine(base.SendSMS(custId, mobile, sms));

            // decorator method to send mail 
            result.AppendLine(SmsSentNotification(custId,sms));

            return result.ToString();
        }
    }
}