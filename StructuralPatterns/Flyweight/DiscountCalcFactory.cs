namespace DesignPatterns
{
    public class DiscountCalcFactory
    {
         public IDiscountCalaculator GetDiscountCalc(string calcType){
             IDiscountCalaculator calaculator=null;
             
             switch(calcType){
                 case "item":
                  calaculator= new CustomerItemsDiscountCalc();
                  break;
                 case "all":
                  calaculator= new CustomerTotalDiscountCalc();
                  break;
             }

             return calaculator;
         }
    }
}