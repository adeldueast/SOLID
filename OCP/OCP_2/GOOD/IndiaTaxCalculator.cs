using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2.GOOD
{
    public class IndiaTaxCalculator : ICountryTaxCalculator
    {
      

        public decimal CalculateTaxAmount()
        {
            //calculate taxAmount for India
            var taxAmount = 200;
            return taxAmount;
        }
    }
}
