using CurrancyConvert;

namespace CurrencyConvertingNunitTest
{
    public class CurrencyConvertTest
    {
        private ConvertingCurrency convertingCurrency { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            convertingCurrency = new ConvertingCurrency();
        }
        [Test]
        public void Converting_Yen_To_USD()
        {
            //Assign
            double yenValue = 1309;
            //Act
            double value = convertingCurrency.YenToUSD(yenValue);
            //Assert
            double expected = 10;
            Assert.IsTrue(value.Equals(expected));
        }

        [Test]
        public void Converting_USD_To_YEN()
        {
            //Assign
            double yenValue = 10;
            //Act
            double value = convertingCurrency.USDToYen(yenValue);
            //Assert
            double expected = 1309;
            Assert.IsTrue(value.Equals(expected));
        }
    }
}