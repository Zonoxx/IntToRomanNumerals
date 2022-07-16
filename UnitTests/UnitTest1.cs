using IntToRomanNumerals;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private ConvertFromIntToNumeral? converter = new ConvertFromIntToNumeral();

        [TestMethod]
        public void SimpleConversion()
        {
            var UserInput = 3;
            var expectedResult = "III";
         

            var result = converter!.ConvertIntToNumeral(UserInput);

            Assert.AreEqual(expectedResult, result);
          
        }

        [TestMethod]
        public void SimpleConversion2()
        {
            var UserInput = 8;
            var expectedResult = "VIII";


            var result = converter!.ConvertIntToNumeral(UserInput);

            Assert.AreEqual(expectedResult, result);

        }
    }
}