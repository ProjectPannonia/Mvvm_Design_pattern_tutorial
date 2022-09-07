using System.ComponentModel;

namespace Mvvm_Design_pattern_tutorial
{
    public class TaxCalculationViewModel : INotifyPropertyChanged
    {
        private TaxCalculationModel _TaxCalculationModel;
        public TaxCalculationViewModel(TaxCalculationModel pTaxCalculationModel)
        {
            _TaxCalculationModel = pTaxCalculationModel;
        }
        public decimal TotalIncome
        {
           get { return _TaxCalculationModel.TotalIncome; }
            set { _TaxCalculationModel.TotalIncome = value; Changed("TotalIncome"); TaxCalculation(); }
        }
        public decimal ExemptedIncome
        {
            get { return _TaxCalculationModel.ExemptedIncome; }
            set { _TaxCalculationModel.ExemptedIncome = value; Changed("ExemptedIncome"); TaxCalculation(); }
        }
        public decimal TaxableIncome
        {
            get { return _TaxCalculationModel.TaxableIncome; }
            set { _TaxCalculationModel.TaxableIncome = value; Changed("TaxableIncome"); }
        }
        public int PercentageOfTax
        {
            get { return _TaxCalculationModel.PercentageOfTax; }
            set { _TaxCalculationModel.PercentageOfTax = value; Changed("PercentageOfTax"); TaxCalculation(); }
        }
        public decimal TaxOnIncome
        {
            get { return _TaxCalculationModel.TaxOnIncome; }
            set {    _TaxCalculationModel.TaxOnIncome = value; Changed("TaxOnIncome"); }
        }
        private void TaxCalculation()
        {
            TaxableIncome = TotalIncome - ExemptedIncome;
            if(TaxableIncome > 0 && PercentageOfTax > 0)
                TaxOnIncome = (PercentageOfTax * TaxableIncome) / 100;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed(string Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
