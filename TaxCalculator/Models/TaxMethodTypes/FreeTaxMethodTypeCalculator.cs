using System;

namespace TaxCalculator.Models.TaxMethodTypes
{
  internal class FreeTaxMethodTypeCalculator : BaseTaxMethodTypeCalculator
  {
    public override decimal CalculateTax(TaxCalculationDetails[] income)
    {
      return 0m;
    }
  }
}