using System;
using System.Text;
using MTTPP_projekt.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MTTPP_projekt.Tests
{
    [TestFixture]
    class CheckProductTest
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


        public void CheckProductTestCaseTest()
        {
            MainPage mainPage = new MainPage();
            ProductListPage productListPage = new ProductListPage();
            ProductPage productPage = new ProductPage();

            driver.Navigate().GoToUrl("https://demo.opencart.com/");

            mainPage.GoToDesktops();
            productListPage.ClickOnProduct();
            productPage.CheckoutProduct();
            productPage.ReturnToMainPage();
        }

        [Test]
        public void RunTestInChrome()
        {
            driver = setUpDriver.SetUp("Chrome");
            SetupTest();
            CheckProductTestCaseTest();
        }

        [Test]
        public void RunTestInFirefox()
        {
            driver = setUpDriver.SetUp("Firefox");
            SetupTest();
            CheckProductTestCaseTest();
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
