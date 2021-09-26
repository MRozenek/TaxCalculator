using System;

namespace TaxCalculator.Models.TaxMethodTypes
{
  internal class NotSetTaxMethodTypeCalculator : BaseTaxMethodTypeCalculator
  {
    public override decimal CalculateTax(TaxCalculationDetails[] income)
    {
      throw new ArgumentException("Tax method type is not set.");
    }
  }
}