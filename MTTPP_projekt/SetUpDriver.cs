using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MTTPP_projekt
{
    public class SetUpDriver
    {
        public static IWebDriver driver;

        public IWebDriver SetUp(string browser)
        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver(@"C:\drivers\Chrome");

            }
            else if (browser == "Firefox")
            {
                driver = new FirefoxDriver();
            }
            return driver;
        }
    }
}
