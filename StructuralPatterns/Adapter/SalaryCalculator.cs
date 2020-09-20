namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class SalaryCalculator
    {
        public double CalcSalary(Employee emp ) => emp.BasicSalary * 1.5;
    }
}