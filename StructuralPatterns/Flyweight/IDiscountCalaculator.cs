using System;

namespace DesignPatterns
{
    public interface IDiscountCalaculator
    {
       double GetDiscountValue(DateTime currentDate, string itemId=null);
    }
}