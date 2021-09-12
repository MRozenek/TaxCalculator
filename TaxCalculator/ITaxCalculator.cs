using TaxCalculator.Models;

namespace TaxCalculator
{
  interface ITaxCalculator
  {
    public decimal CalculateTaxIncome(TaxCalculationDetails[] income, TaxAccountingMethodType methodType);
  }
}