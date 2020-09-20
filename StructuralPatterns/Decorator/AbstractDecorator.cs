namespace DesignPatterns.StructuralPatterns
{
    public abstract class AbstractDecorator: SMSService
    {
       protected SMSService notificationService ;
       public void SetService(SMSService service){
           notificationService = service;
       }
       
      public override string SendSMS(string custId, string mobile, string sms){
          if(notificationService != null )
          {return notificationService.SendSMS(custId,mobile,sms);}
          else {return "Notification service not initialized!";}
      }   
    }
}