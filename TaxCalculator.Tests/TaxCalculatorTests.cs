using Microsoft.Extensions.Configuration;
using TaxCalculator.Models;
using Xunit;

namespace TaxCalculator.Tests
{
  public class TaxCalculatorTests
  {
    private TaxCalculator _cut;

    public TaxCalculatorTests()
    {
      //var config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();
      _cut = new TaxCalculator();
    }

    [Fact]
    public void CalculateTaxIncome_FreeTaxMethodAndTwo5000Payments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 0m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 5000m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTaxIncome(taxIncomes, Models.TaxAccountingMethodType.Free);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_FlatTaxMethodAndTwo5001Payments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 1900m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5001m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 5001m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTaxIncome(taxIncomes, Models.TaxAccountingMethodType.Flat);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndOne5000Payment_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 324m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTaxIncome(taxIncomes, Models.TaxAccountingMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }
  }
}