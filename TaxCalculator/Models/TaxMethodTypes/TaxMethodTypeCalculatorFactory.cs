namespace TaxCalculator.Models.TaxMethodTypes
{
  internal class TaxMethodTypeCalculatorFactory
  {
    internal BaseTaxMethodTypeCalculator Create(TaxMethodType taxMethodType)
    {
      switch (taxMethodType)
      {
        case TaxMethodType.Free:
          return new FreeTaxMethodTypeCalculator();
        case TaxMethodType.Flat:
          return new FlatTaxMethodTypeCalculator();
        case TaxMethodType.Progressive:
          return new ProgressiveTaxMethodTypeCalculator();
        case TaxMethodType.NotSet:
        default:
          return new NotSetTaxMethodTypeCalculator();
      }
    }
  }
}