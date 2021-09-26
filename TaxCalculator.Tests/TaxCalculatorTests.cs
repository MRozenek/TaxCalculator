using TaxCalculator.Models;
using TaxCalculator.Models.TaxMethodTypes;
using Xunit;

namespace TaxCalculator.Tests
{
  public class TaxCalculatorTests
  {
    private readonly TaxCalculator _cut;

    public TaxCalculatorTests()
    {
      _cut = new TaxCalculator();
    }

    [Fact]
    public void CalculateTaxIncome_FreeTaxMethodAndTwo5kPayments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 0m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 5000m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Free);

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

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Flat);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndOne5kPayment_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 324m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndOne300Payment_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 0m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 300, Month = 1, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndOne300And200Payment_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 0m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 300, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 200, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndTwo5k5kPayments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 1174m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 5000m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndTwo5k10kPayments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 2024m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 10000m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }

    [Fact]
    public void CalculateTaxIncome_ProgressiveTaxMethodAndTwo5k100kPayments_ExpectedCalculationResult()
    {
      var expectedTaxCalculationResult = 19920m;
      TaxCalculationDetails[] taxIncomes = new TaxCalculationDetails[] {
        new TaxCalculationDetails { Amount = 5000m, Month = 1, Year = 2021 },
        new TaxCalculationDetails { Amount = 100000m, Month = 2, Year = 2021 },
      };

      var taxCalculationResult = _cut.CalculateTax(taxIncomes, TaxMethodType.Progressive);

      Assert.Equal(expectedTaxCalculationResult, taxCalculationResult);
    }
  }
}