using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MTTPP_projekt.Pages
{
    class ProductListPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        public void ClickOnProduct()
        {
            driver.FindElement(By.XPath("//img[@alt='Apple Cinema 30\"']")).Click();
        }

        public void AddProductToWishList()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/div[4]/div[1]/div/div[2]/div[2]/button[2]/i")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]/a[2]")));
            webElement.Click();
        }

        public void AddProductToCart()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/div[4]/div[4]/div/div[2]/div[2]/button[1]")));
            webElement.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]")));
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/header/div/div/div[3]/div/button")));
            webElement.Click();
            webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Checkout")));
            webElement.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div[1]")));
        }
    }
}
