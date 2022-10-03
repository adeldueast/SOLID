using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.BAD
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;
        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devReport in _developerReports)
            {
                if (devReport.Level == "Senior developer")
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 3;
                }
                else
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
                }
            }
            return totalSalaries;
        }
    }
}
