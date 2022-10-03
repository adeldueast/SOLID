using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2.GOOD
{
    public class TaxCalculator
    {

        public decimal Calculate(ICountryTaxCalculator countryTaxCalculator)
        {
            return countryTaxCalculator.CalculateTaxAmount();
        }
    }
}
