using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2.GOOD
{
    public class CanadaTaxCalculator : ICountryTaxCalculator
    {
     

        public decimal CalculateTaxAmount()
        {
            //calculate taxAmount
            var taxAmount = 100;
            return taxAmount;
        }
    }
}
