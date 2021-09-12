using TaxCalculator.Models;
using Xunit;

namespace TaxCalculator.Tests
{
  public class TaxCalculatorTests
  {
    private TaxCalculator _cut;

    public TaxCalculatorTests()
    {
      _cut = new TaxCalculator();
    }

    [Fact]
    public void CalculateTaxIncome_MethodIsProgressiveAndOne5000Payment_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 324m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 }
      };

      var taxCalculationResult = _cut.CalculateTaxIncome(taxIncomes, Models.TaxAccountingMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }
  }
}