﻿using Microsoft.Extensions.Configuration;
using System;
using TaxCalculator.Models;

namespace TaxCalculator
{
  public class TaxCalculator : ITaxCalculator
  {
    private readonly decimal FlatTaxIncomeValueInPercent;
    private readonly decimal ProgressiveTaxIncomeFirstLimit;
    private readonly decimal ProgressiveTaxIncomeFirstValueInPercent;
    private readonly decimal ProgressiveTaxIncomeSecondLimit;
    private readonly decimal ProgressiveTaxIncomeSecondValueInPercent;

    public TaxCalculator()
    {
      var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
      FlatTaxIncomeValueInPercent = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("FlatTaxIncomeValueInPercent").Value);
      ProgressiveTaxIncomeFirstLimit = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("ProgressiveTaxIncomeFirstLimit").Value);
      ProgressiveTaxIncomeFirstValueInPercent = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("ProgressiveTaxIncomeFirstValueInPercent").Value);
      ProgressiveTaxIncomeSecondLimit = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("ProgressiveTaxIncomeSecondLimit").Value);
      ProgressiveTaxIncomeSecondValueInPercent = decimal.Parse(config.GetSection("ApplicationSettings").GetSection("ProgressiveTaxIncomeSecondValueInPercent").Value);
    }

    public decimal CalculateTaxIncome(TaxCalculationDetails[] income, TaxAccountingMethodType methodType)
    {
      switch (methodType)
      {
        case TaxAccountingMethodType.Free:
          return 0m;
        case TaxAccountingMethodType.Flat:
          return CalculateFlatTaxIncome(income);
        case TaxAccountingMethodType.Progressive:
          return CalculateProgressiveTaxIncome(income);
        case TaxAccountingMethodType.NotSet:
        default:
          throw new ArgumentException("Tax accounting method is not set.");
      }
    }

    private decimal CalculateFlatTaxIncome(TaxCalculationDetails[] income)
    {
      var taxIncome = 0m;

      foreach (var item in income)
      {
        taxIncome += decimal.Round(item.Amount * FlatTaxIncomeValueInPercent, MidpointRounding.ToZero);
      }

      return taxIncome;
    }

    private decimal CalculateProgressiveTaxIncome(TaxCalculationDetails[] income)
    {
      if (ProgressiveTaxIncomeFirstValueInPercent != 0.00m)
      {
        throw new ArgumentException("Progressive tax income calculations are always expecting that there is always some zero percent income up to some limit free of charge. "
          + $"Set back ProgressiveTaxIncomeFirstValueInPercent within AppSettings.json file to 0.00 from {ProgressiveTaxIncomeFirstValueInPercent}, "
          + "however if youneed to not use 0.00 rate at all you can set ProgressiveTaxIncomeFirstLimit value to 0.");
      }

      var taxIncome = 0m;
      var currentProgressiveTaxIncomeFirstLimit = ProgressiveTaxIncomeFirstLimit;

      foreach (var item in income)
      {
        taxIncome += item.Amount * ProgressiveTaxIncomeSecondValueInPercent;
        taxIncome -= currentProgressiveTaxIncomeFirstLimit;
        currentProgressiveTaxIncomeFirstLimit = 0m;
        taxIncome = decimal.Round(taxIncome, MidpointRounding.ToZero);
      }

      return taxIncome;
    }
  }
}