﻿using TaxCalculator.Models;

namespace TaxCalculator
{
  public class TaxCalculator : ITaxCalculator
  {
    public void CalculateTaxIncome(
      Employee employee,
      decimal income,
      TaxCalculationPeriod taxCalculationPeriod,
      TaxAccountingMethodType methodType)
    {
      throw new System.NotImplementedException();
    }
  }
}