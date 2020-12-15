using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AspNetCore.SpecFlow
{
    public class ExampleTest
    {
        [Test]
        public void Test()
        {
            var _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.google.com.br/");
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}