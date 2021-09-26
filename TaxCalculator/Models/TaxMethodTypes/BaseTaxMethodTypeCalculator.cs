namespace TaxCalculator.Models.TaxMethodTypes
{
  internal abstract class BaseTaxMethodTypeCalculator
  {
    public abstract decimal CalculateTax(TaxCalculationDetails[] income);
  }
}