using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GOOD
{
    public class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public DeveloperReport DeveloperReport { get; set; }

        public SeniorDevSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 3;
    }
}
