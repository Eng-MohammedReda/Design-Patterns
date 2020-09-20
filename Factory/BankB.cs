namespace DesignPatterns.Factory
{
    public class BankB:IBank
    {
        public  string Withdraw(){
            return "Your request is handling by BankB";
        }
    }
}