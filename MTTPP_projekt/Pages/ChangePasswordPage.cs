using OpenQA.Selenium;

namespace MTTPP_projekt.Pages
{
    class ChangePasswordPage : SetUpDriver
    {

        public void InputNewPassword(string password)
        {
            driver.FindElement(By.Id("input-password")).Click();
            driver.FindElement(By.Id("input-password")).Clear();
            driver.FindElement(By.Id("input-password")).SendKeys(password);
            driver.FindElement(By.Id("input-confirm")).Click();
            driver.FindElement(By.Id("input-confirm")).Clear();
            driver.FindElement(By.Id("input-confirm")).SendKeys(password);
        }

        public void ClickConfirm()
        {
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
        }
    }
}
