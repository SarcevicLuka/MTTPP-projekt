using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MTTPP_projekt.Pages
{
    class LoginPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        public void InputEmail(string email)
        {
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys(email);
        }

        public void InputPassword(string password)
        {
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys(password);
        }

        public void ClickLogin()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@value='Login']")));
            webElement.Click();
        }

        public void Logout()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@id='top-links']/ul/li[2]/a")));
            webElement.Click();

            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Logout")));
            webElement.Click();

            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Continue")));
            webElement.Click();
        }
    }
}
