using OCP_2.BAD;
using OCP_2.GOOD;


//Breaks Open/Closed Principle, because if we want to add a new country, we have to
//go back in and edit the existing TaxCalculator Class
OCP_2.BAD.TaxCalculator taxCalculator1 = new();
var canadaTaxes1 = taxCalculator1.Calculate("Canada"); //100
var indiaTaxes2 = taxCalculator1.Calculate("India");//200
var usaTaxes3 = taxCalculator1.Calculate("USA"); //300



//Respects Open/Closed Principle, because if we want to add a new country, we simply have to
//create a CountryTaxCalculator class that implements its own Calculate function 
//So basically, our TaxCalculator class is now closed for modification and opened for an extension, which is exactly what OCP states.
OCP_2.GOOD.TaxCalculator taxCalculator = new();
var canadaTaxes = taxCalculator.Calculate(new CanadaTaxCalculator()); //100
var indiaTaxes = taxCalculator.Calculate(new IndiaTaxCalculator());//200
var usaTaxes = taxCalculator.Calculate(new UsaTaxCalculator()); //300

