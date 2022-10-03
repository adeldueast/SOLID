using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2.GOOD
{
    public class UsaTaxCalculator : ICountryTaxCalculator
    {

        public decimal CalculateTaxAmount()
        {
            //calculate taxAmount for USA
            var taxAmount = 300;
            return taxAmount;

        }
    }
}