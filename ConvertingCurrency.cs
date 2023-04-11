namespace CurrancyConvert
{
    public class ConvertingCurrency
    {
        public double YenToUSD(double amount)
        {
            return amount / 130.9;
        }

        public double USDToYen(double amount)
        {
            return amount * 130.9;
        }
    }
}