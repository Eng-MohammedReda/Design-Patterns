namespace DesignPatterns
{
    public class CustomerItemsDiscountCalc:IDiscountCalaculator
    {
      
        public double GetDiscountValue(string custId, string itemId)
        {
          // call database to get customer transactions,
          // sum total payment for specific item transaction
          // if sum > 950, apply discount  
          var custTotalTransactions = 1000;
          return (custTotalTransactions > 950) ? 0.10:0.0;
        }
    }
}