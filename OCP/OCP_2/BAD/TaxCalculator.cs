using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_2.BAD
{
    public class TaxCalculator
    {

        public decimal Calculate(string country)
        {
            decimal taxAmount = 0;

            switch (country)
            {
                case "Canada":
                    //calculate here..
                    taxAmount = 100;
                    break;
                case "India":
                    //calculate here..
                    taxAmount = 200;
                    break;
                case "USA":
                    //calculate here..
                    taxAmount = 300;
                    break;

            }

            return taxAmount;

        }
    }
}
