using TaxCalculator.Models;
using TaxCalculator.Models.TaxMethodTypes;

namespace TaxCalculator
{
  interface ITaxCalculator
  {
    public decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType);
  }
}