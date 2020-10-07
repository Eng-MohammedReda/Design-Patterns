using System;

namespace DesignPatterns
{
    public class ItemsDiscountCalc:IDiscountCalaculator
    {
      
        public double GetDiscountValue(DateTime currentDate, string itemId)
        {
          // call database to calc item discount
         return 0.10;
        }
    }
}