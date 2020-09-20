using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.StructuralPatterns.Facade
{
    public class ShoppingBasket
    {
        private List<BasketItem> _items = new List<BasketItem>();
        public void AddItem(BasketItem item)
        {
            _items.Add(item);
        }

        public void RemoveOneItem(string itemID)
        {
            var item = _items.Where(x => x.ItemID == itemID).Single();
            if (item.Quantity > 0) item.Quantity = item.Quantity - 1;
        }

        public List<BasketItem> GetItems() { return _items; }

    }
}