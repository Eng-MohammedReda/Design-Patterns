namespace DesignPatterns.Builder
{
    public class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations() {/*Start*/}
        public void BuildBody()
        {
            product.Add("Body was added");
        }
        public void InsertWheels()
        {
            product.Add("wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("Headlights are added");
        }
        public void EndOperations()
        {
            product.Add($"Motorcycle brand name {this.brandName}");
        }
        public Product GetVehicle() { return product; }
    }
}