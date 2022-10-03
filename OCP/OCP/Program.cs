


using OCP;
using OCP.GOOD;

var devReports = new List<DeveloperReport>
    {
        new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
        new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
        new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
    };

var calculator = new OCP.BAD.SalaryCalculator(devReports);
Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");





var devCalculations = new List<ISalaryCalculator>
    {
        new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 }),
        new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 }),
        new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 })
    };

var calculator2 = new OCP.GOOD.SalaryCalculator(devCalculations);
Console.WriteLine($"Sum of all the developer salaries is {calculator2.CalculateTotalSalaries()} dollars");
