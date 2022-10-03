using SRP.GOOD;
using SRP;

//its job is not only to keep track of our work report entries but to save the entire work report to a file.
//This means that we are violating the SRP and our class has more than one reason to change in the future.

//The first reason to change this class is if we want to modify the way we keep track of our entries.
//But if we want to save a file in a different way, that is entirely a new reason to change our class.
//And imagine what this class would look like if we added additional functionalities to it. We would have so many unrelated code parts in a single class.
var report = new SRP.BAD.WorkReport();
report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
Console.WriteLine(report.ToString());
report.SaveToFile(@"Reports", "WorkReport.txt");



//In this case, we have separated our responsibilities in two classes.
//The WorkReport class is now responsible for keeping track of work report entries and the FileSaver class is responsible for saving a file.
var report2 = new SRP.GOOD.WorkReport();
report2.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
report2.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
Console.WriteLine(report2.ToString());
var saver = new FileSaver();
saver.SaveToFile(@"Reports", "WorkReport2.txt", report2);
