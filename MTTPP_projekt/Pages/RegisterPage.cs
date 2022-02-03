using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MTTPP_projekt.Pages
{
    class RegisterPage : SetUpDriver
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));


        public void InputFirstName(string firstName)
        {
            driver.FindElement(By.Id("input-firstname")).Click();
            driver.FindElement(By.Id("input-firstname")).Clear();
            driver.FindElement(By.Id("input-firstname")).SendKeys(firstName);
        }

        public void InputLasttName(string lastName)
        {
            driver.FindElement(By.Id("input-lastname")).Click();
            driver.FindElement(By.Id("input-lastname")).Clear();
            driver.FindElement(By.Id("input-lastname")).SendKeys(lastName);
        }

        public void InpuEmail(string email)
        {
            driver.FindElement(By.Id("input-email")).Click();
            driver.FindElement(By.Id("input-email")).Clear();
            driver.FindElement(By.Id("input-email")).SendKeys(email);
        }

        public void InputTelephoneNumber(string telephoneNumber)
        {
            driver.FindElement(By.Id("input-telephone")).Click();
            driver.FindElement(By.Id("input-telephone")).Clear();
            driver.FindElement(By.Id("input-telephone")).SendKeys(telephoneNumber);
        }

        public void InputPassword(string password)
        {
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys(password);
            driver.FindElement(By.Id("input-confirm")).Click();
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys(password);
        }

        public void FinishRegistering()
        {
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
        }

        public void ApproveRegistering()
        {
            IWebElement webElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Continue")));
            webElement.Click();
        }
    }
}
