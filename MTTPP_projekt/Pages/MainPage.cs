using OpenQA.Selenium;

namespace MTTPP_projekt.Pages
{
    class MainPage : SetUpDriver
    {

        public void ClickLogin()
        {
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
        }

        public void ClickRegister()
        {
            driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[1]/a")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
        }

        public void GoToDesktops()
        {
            driver.FindElement(By.LinkText("Desktops")).Click();
            driver.FindElement(By.LinkText("Show All Desktops")).Click();
        }
    }
}
