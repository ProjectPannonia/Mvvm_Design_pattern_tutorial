namespace Mvvm_Design_pattern_tutorial
{
    public class TaxCalculationModel
    {
        public decimal TotalIncome { get; set; }
        public decimal ExemptedIncome { get; set; }
        public decimal TaxableIncome { get; set; }
        public int PercentageOfTax { get; set; }
        public decimal TaxOnIncome { get; set; }

    }
}
