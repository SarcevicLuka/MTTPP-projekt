using System;
using System.Text;
using MTTPP_projekt.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MTTPP_projekt.Tests
{
    [TestFixture]
    public class PasswordChangeTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        SetUpDriver setUpDriver = new SetUpDriver();

        [SetUp]
        public void SetupTest()
        {
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        public void PasswordChangeTestCaseTest()
        {
            MainPage mainPage = new MainPage();
            LoginPage loginPage = new LoginPage();
            AccountPage accountPage = new AccountPage();
            ChangePasswordPage changePasswordPage = new ChangePasswordPage();

            driver.Navigate().GoToUrl("https://demo.opencart.com/index.php?route=common/home");

            mainPage.ClickLogin();
            loginPage.InputEmail("luk@gmail.com");
            loginPage.InputPassword("luk2508");
            loginPage.ClickLogin();
            accountPage.ClickPasswordOption();
            changePasswordPage.InputNewPassword("lu2508");
            changePasswordPage.ClickConfirm();

        }

        [Test]
        public void RunTestInChrome()
        {
            driver = setUpDriver.SetUp("Chrome");
            SetupTest();
            PasswordChangeTestCaseTest();
        }

        [Test]
        public void RunTestInFirefox()
        {
            driver = setUpDriver.SetUp("Firefox");
            SetupTest();
            PasswordChangeTestCaseTest();
        }


        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}