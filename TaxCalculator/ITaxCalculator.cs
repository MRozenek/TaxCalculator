using TaxCalculator.Models;

namespace TaxCalculator
{
  interface ITaxCalculator
  {
    public decimal CalculateTax(TaxCalculationDetails[] income, TaxMethodType taxMethodType);
  }
}