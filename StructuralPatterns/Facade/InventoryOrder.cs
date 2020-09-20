namespace DesignPatterns.StructuralPatterns.Facade
{
    public class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket basket,string storeID){
             basket.GetItems();
             return $"Order Number is {System.Guid.NewGuid().ToString()}";
        }
    }
}