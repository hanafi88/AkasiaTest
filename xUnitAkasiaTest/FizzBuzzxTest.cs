using BusinessLogic;
using BusinessLogic.Services;

namespace xUnitAkasiaTest
{
    public class FizzBuzzXTest
    {
        private IFizzBuzzService? _iFizzBuzzServiceXTest;

        [Fact]
        public void FizzBuzzServiceTest()
        {
            int iMaxLoop = 100;
            //arrange logics
            var request = new FizzBuzzService(iMaxLoop);
            var sExpectedResult = string.Empty;

            //act logics
            _iFizzBuzzServiceXTest = new FizzBuzzService(iMaxLoop);
            var sActualResult = _iFizzBuzzServiceXTest.Write();

            //assert logics
            Assert.Equal(sExpectedResult, sActualResult);
        }
    }
}