namespace DesignPatterns.Builder
{
    public class Director
    {
        IBuilder builder;
        // steps to create complex object
        public void Construct(IBuilder builder){
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}