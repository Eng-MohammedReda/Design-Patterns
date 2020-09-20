namespace DesignPatterns.StructuralPatterns.Facade
{
    public class PurchaseOrder
    {
        public bool CreateOrder(ShoppingBasket basket,
                                string custInfo){
               // check stock
               bool isAvailable =true;
               Inventory inventory = new Inventory ();
               
               foreach(var item in basket.GetItems()){
                if(!inventory.CheckItemQuantity(item.ItemID,item.Quantity))
                 isAvailable=false ;
               }
               
               if(isAvailable){
                    // Create Inventory Order
               InventoryOrder inventoryOrder=new InventoryOrder ();
               inventoryOrder.CreateOrder(basket,"123");

               // Create Invoice 
               PurchaseInvoice invoice = new PurchaseInvoice ();
               var inv=invoice.CreateInvoce(basket,"address:132,id=456,email=xyz");
               
               // Payment
               PaymentProcessor payment=new PaymentProcessor ();
               payment.HandlePayment(inv.netTotal,"acc=123456789");

               // Send SMS
               SmsNotifications sms=new SmsNotifications ();
               sms.SendSms("123","Invoice Created");

               return true;
               }else {return false ;}
               
               
              
       }
    }
}