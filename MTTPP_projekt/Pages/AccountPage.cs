using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MTTPP_projekt.Pages
{
    class AccountPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        public void ClickPasswordOption()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Password")));
            webElement.Click();
        }
    }
}
