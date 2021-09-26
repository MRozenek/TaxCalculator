using Microsoft.Extensions.Configuration;
using System;

namespace TaxCalculator.Models.TaxMethodTypes
{
  internal class FlatTaxMethodTypeCalculator : BaseTaxMethodTypeCalculator
  {
    private readonly decimal FlatTaxIncomeValueInPercent;

    public FlatTaxMethodTypeCalculator()
    {
      var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
      FlatTaxIncomeValueInPercent = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("FlatTaxIncomeValueInPercent").Value);
    }

    public override decimal CalculateTax(TaxCalculationDetails[] income)
    {
      var taxIncome = 0m;

      foreach (var item in income)
      {
        taxIncome += decimal.Round(item.Amount * FlatTaxIncomeValueInPercent, MidpointRounding.ToZero);
      }

      return taxIncome;
    }
  }
}