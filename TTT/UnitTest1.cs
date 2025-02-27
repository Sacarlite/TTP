using Aquality.Selenium.Browsers;

namespace TTT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            AqualityServices.Logger.Info($"Start test");
        }

        [Test]
        public void Test1()
        {
            AqualityServices.Logger.Info($"Successful test");
            Assert.True(true);
        }
        [Test]
        public void Test2()
        {
            AqualityServices.Logger.Info($"Fail test");
            Assert.True(false);
        }
        [Test]
        public void Test3()
        {
            AqualityServices.Logger.Info($"Successful test");
            Assert.True(true);
        }
        [TearDown]
        public void TearDown()
        {
            AqualityServices.Logger.Info($"End test");
        }
    }
}