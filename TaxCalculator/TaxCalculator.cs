using Microsoft.Extensions.Configuration;
using System;
using TaxCalculator.Models;
using TaxCalculator.Models.TaxMethodTypes;

namespace TaxCalculator
{
  public class TaxCalculator : ITaxCalculator
  {    
    public decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType)
    {
      switch (taxMethodType)
      {
        case TaxMethodType.Free:
          return new FreeTaxMethodTypeCalculator().CalculateTax(income);
        case TaxMethodType.Flat:
          return new FlatTaxMethodTypeCalculator().CalculateTax(income);
        case TaxMethodType.Progressive:
          return new ProgressiveTaxMethodTypeCalculator().CalculateTax(income);
        default:
          return new NotSetTaxMethodTypeCalculator().CalculateTax(income);
      }
    }
  }
}