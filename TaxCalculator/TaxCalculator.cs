using TaxCalculator.Models;
using TaxCalculator.Models.TaxMethodTypes;

namespace TaxCalculator
{
  public class TaxCalculator : ITaxCalculator
  {    
    public decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType)
    {
      var factory = new TaxMethodTypeCalculatorFactory();
      var taxCalculator = factory.Create(taxMethodType);
      var tax = taxCalculator.CalculateTax(income);

      return tax;
    }
  }
}