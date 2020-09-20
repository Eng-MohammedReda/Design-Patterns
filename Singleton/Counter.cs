namespace DesignPatterns.Singleton
{
    public class Counter
    {
        public int count=0;
        private static Counter instance = null;
        private static  object lockObj = new object ();
        private Counter(){}
         
        public static Counter GetInstance (){
            if(instance == null){
            lock(lockObj){
                 if  (instance==null) {instance = new Counter();}
            }
            }
           return instance;
        }
        public void AddOne(){count++;}
    }
}