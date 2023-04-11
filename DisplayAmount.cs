using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrancyConvert
{
    internal class DisplayAmount
    {
        private readonly ConvertingCurrency convertingCurrency;
        public DisplayAmount(ConvertingCurrency convertingCurrency)
        {
            this.convertingCurrency = convertingCurrency;
        }
        public void ConvertedUSD(double amount)
        {
            convertingCurrency.YenToUSD(amount);
        }
        public void ConvertedYen(double amount)
        {
            convertingCurrency.USDToYen(amount);
        }

    }
}
