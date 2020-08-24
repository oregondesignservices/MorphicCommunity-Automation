using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MorphicCommunityAutomation.Objects
{
    class Login : SetUp
    {
        [Test]
        public void GoToHomeURL()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/#/");

        }

        [Test]
        public void CheckIncorrectPassword()
        {
            IWebElement EMAIL = driver.FindElement(By.CssSelector("fieldset:nth-of-type(1) > div[role='group'] > input[label='Email']"));
            IWebElement PASSWORD = driver.FindElement(By.CssSelector("fieldset:nth-of-type(2) > div[role='group'] > input[label='Password']"));
            IWebElement LOGIN_BTN = driver.FindElement(By.CssSelector(".col-md-3 > div > form > .btn.btn-primary"));
            EMAIL.SendKeys("dasda@adsad.das");
            PASSWORD.SendKeys("13213123123123");
            LOGIN_BTN.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            string INCORRECT_USRNAME_PSWORD = driver.FindElement(By.CssSelector("div[role='alert']")).Text;
            Assert.AreEqual(INCORRECT_USRNAME_PSWORD, "Incorrect username or password!");

        }


        [Test]
        public void EmptyUserNameAndPassword()
        {
            driver.Navigate().Refresh();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("fieldset:nth-of-type(1) > div[role='group'] > input[label='Email']")));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement EMAIL = driver.FindElement(By.CssSelector("fieldset:nth-of-type(1) > div[role='group'] > input[label='Email']"));
            IWebElement PASSWORD = driver.FindElement(By.CssSelector("fieldset:nth-of-type(2) > div[role='group'] > input[label='Password']"));
            IWebElement LOGIN_BTN = driver.FindElement(By.CssSelector(".col-md-3 > div > form > .btn.btn-primary"));
            EMAIL.SendKeys("1");
            PASSWORD.SendKeys("2");
            LOGIN_BTN.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            string INCORRECT_USRNAME = driver.FindElement(By.CssSelector("fieldset:nth-of-type(1) > div[role='group'] > .invalid-feedback")).Text;
            Assert.AreEqual(INCORRECT_USRNAME, "This is a required field and must be a valid email address.");
            string INCORRECT_PASSWORD = driver.FindElement(By.CssSelector(".col-md-3 > div > form > fieldset:nth-of-type(2) > div[role='group'] > .invalid-feedback")).Text;
            Assert.AreEqual(INCORRECT_PASSWORD, "This is a required field and must be at least 6 characters.");

        }

        [Test]
        public void CheckCorrectCredentials()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/#/");
            driver.Navigate().Refresh();
            IWebElement EMAIL = driver.FindElement(By.CssSelector("fieldset:nth-of-type(1) > div[role='group'] > input[label='Email']"));
            IWebElement PASSWORD = driver.FindElement(By.CssSelector("fieldset:nth-of-type(2) > div[role='group'] > input[label='Password']"));
            IWebElement LOGIN_BTN = driver.FindElement(By.CssSelector(".col-md-3 > div > form > .btn.btn-primary"));
            EMAIL.SendKeys("ivaylo@raisingthefloor.org");
            PASSWORD.SendKeys("123123123");
            LOGIN_BTN.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement LOGOUT = driver.FindElement(By.CssSelector("#top .navbar-nav:nth-child(3) .nav-link"));
            LOGOUT.Click();
            string currenturl = driver.Url;
            Assert.AreEqual(currenturl, "http://localhost:8080/#/");
        }

    }
}
