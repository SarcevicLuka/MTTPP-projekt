using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MTTPP_projekt.Pages
{
    class ProductPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        public void CheckoutProduct()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//img[@alt='Apple Cinema 30\"']")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[2]")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[2]")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[2]")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[2]")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[2]")));
            webElement.Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }

        public void ReturnToMainPage()
        {
            driver.FindElement(By.LinkText("Your Store")).Click();
        }
    }
}
