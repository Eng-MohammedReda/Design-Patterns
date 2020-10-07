using System.Collections.Generic;

namespace DesignPatterns
{
    public class DiscountCalcFactory
    {
         public IDiscountCalaculator GetDiscountCalc(string calcType){
             IDiscountCalaculator calaculator=null;
             Dictionary<string,IDiscountCalaculator> calcLst=new Dictionary<string, IDiscountCalaculator> ();
             
             if (calcLst.ContainsKey(calcType)){
                 return calcLst[calcType];
             }else{
                 switch(calcType){
                 case "day":
                  calaculator= new DayDiscountCalc();
                  calcLst.Add("day",calaculator);
                  break;
                 case "item":
                  calaculator= new ItemsDiscountCalc();
                  calcLst.Add("item",calaculator);
                  break;
             }
             return calaculator;
             }

         }
    }
}