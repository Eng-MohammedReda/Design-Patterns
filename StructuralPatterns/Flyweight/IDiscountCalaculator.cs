namespace DesignPatterns
{
    public interface IDiscountCalaculator
    {
       double GetDiscountValue(string custId,string itemId=null);
    }
}