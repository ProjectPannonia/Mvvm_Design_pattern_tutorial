using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_Design_pattern_tutorial
{
    //https://www.clariontech.com/blog/wpf-with-mvvm-easily-separate-ui-and-business-logic
    public class TaxCalculationViewModel :INotifyPropertyChanged
    {
        private TaxCalculationModel _TaxCalculationModel;
        public TaxCalculationViewModel(TaxCalculationModel pTaxCalculationModel)
        {
            _TaxCalculationModel = pTaxCalculationModel;
        }
        public decimal TotalIncome
        {
            
        }
    }
}
