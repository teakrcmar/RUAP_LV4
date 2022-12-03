using NUnit.Framework;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class Test
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
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

        [Test]
        public void The1Test()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
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

        [Test]
        public void The2Test()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Register")).Click();
        }

        [Test]
        public void The3Test()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Test");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Example");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("mailforme34@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("testPassword123");
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testPassword123");
            driver.FindElement(By.Id("register-button")).Click();
        }

        [Test]
        public void The4Test()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Test");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Example");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("mailforme33@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("testPassword123");
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testPassword13");
            driver.FindElement(By.Id("register-button")).Click();
        }

        [Test]
        public void The5Test()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("FirstName")).Click();
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Test");
            driver.FindElement(By.Id("LastName")).Clear();
            driver.FindElement(By.Id("LastName")).SendKeys("Example");
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("mailforme34@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("testPassword123");
            driver.FindElement(By.Id("ConfirmPassword")).Clear();
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testPassword123");
            driver.FindElement(By.Id("register-button")).Click();
        }
    }
}
