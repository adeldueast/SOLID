using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.GOOD
{
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {


        public DeveloperReport DeveloperReport { get; set; }

        public JuniorDevSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }


        public double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
}
