

namespace OCP.GOOD
{
    public interface ISalaryCalculator
    {
        public DeveloperReport DeveloperReport { get; set; }

        public double CalculateSalary();
    }
}
