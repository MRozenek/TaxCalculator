using TaxCalculator.Models;

namespace TaxCalculator
{
  interface ITaxCalculator
  {
    public void CalculateTaxIncome(
      Employee employee,
      decimal income,
      TaxCalculationPeriod taxCalculationPeriod,
      TaxAccountingMethodType methodType);
  }
}