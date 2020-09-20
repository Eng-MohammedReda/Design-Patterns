namespace DesignPatterns.StructuralPatterns.Facade
{
    public class Inventory
    {
        public bool CheckItemQuantity(string itemID,double quantity){
            return quantity < 100;
        }
    }
}