using Microsoft.Extensions.Configuration;
using System;
using TaxCalculator.Models;

namespace TaxCalculator
{
  public class TaxCalculator : ITaxCalculator
  {
    private readonly decimal FlatTaxIncomeValueInPercent;

    public TaxCalculator()
    {
      var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
      FlatTaxIncomeValueInPercent = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("FlatTaxIncomeValueInPercent").Value);
    }

    public decimal CalculateTaxIncome(TaxCalculationDetails[] income, TaxAccountingMethodType methodType)
    {
      switch (methodType)
      {
        case TaxAccountingMethodType.Free:
          return 0m;
        case TaxAccountingMethodType.Flat:
          var taxIncome = 0m;

          foreach (var item in income)
          {
            taxIncome += decimal.Round(item.Amount * FlatTaxIncomeValueInPercent);
          }
          return taxIncome;
        case TaxAccountingMethodType.Progressive:
          throw new NotImplementedException();
        case TaxAccountingMethodType.NotSet:
        default:
          throw new ArgumentException("Tax accounting method is not set.");
      }
    }
  }
}