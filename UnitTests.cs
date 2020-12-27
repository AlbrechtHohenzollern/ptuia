using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace testy1
{
    [TestClass]
    public class TestSuite
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver(Environment.CurrentDirectory);
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheTC1Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-01-2011");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC2Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2010");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC3Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC4Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2010");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Mlodzik", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC5Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-01-2007");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Mlodzik", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC6Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2006");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC7Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2006");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC8Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2006");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Junior", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC9Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-01-2003");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Junior", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC10Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-2002");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Dorosly", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC11Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-01-1956");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Dorosly", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC12Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-1955");
            driver.FindElement(By.Id("rodzice")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Brak kwalifikacji", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC13Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-1955");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Senior", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC14Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-01-1900");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Senior", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC15Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("31-12-1899");
            driver.FindElement(By.Id("lekarz")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC16Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-00-2000");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC17Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("01-13-2000");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC18Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("00-01-2000");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC19Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("32-01-2000");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
        }

        [TestMethod]
        public void TheTC20Test()
        {
            driver.Navigate().GoToUrl("https://lamp.ii.us.edu.pl/~mtdyd/zawody/");
            driver.FindElement(By.Id("inputEmail3")).Click();
            driver.FindElement(By.Id("inputEmail3")).Clear();
            driver.FindElement(By.Id("inputEmail3")).SendKeys("Jan");
            driver.FindElement(By.Id("inputPassword3")).Click();
            driver.FindElement(By.Id("inputPassword3")).Clear();
            driver.FindElement(By.Id("inputPassword3")).SendKeys("Kowalski");
            driver.FindElement(By.Id("dataU")).Click();
            driver.FindElement(By.Id("dataU")).Clear();
            driver.FindElement(By.Id("dataU")).SendKeys("aa-bb-cccc");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            CloseAlertAndGetItsText();
            Assert.AreEqual("Blad danych", CloseAlertAndGetItsText());
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
