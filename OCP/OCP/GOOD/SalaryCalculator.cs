using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GOOD
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<ISalaryCalculator> _developerCalculation;
        public SalaryCalculator(IEnumerable<ISalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }


        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }
            return totalSalaries;
        }
    }
}
