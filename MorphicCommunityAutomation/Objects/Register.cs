using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MorphicCommunityAutomation.Objects
{
    class Register : SetUp
    {

        [Test]
        public void CheckErrorMessages()
        {
            IWebElement CREATE_COMMUNITY_BTN = driver.FindElement(By.CssSelector("button[type='submit']"));
            CREATE_COMMUNITY_BTN.Click();

            string GET_ERROR_MSG_USRNAME = driver.FindElement(By.CssSelector(".col-md-4 > form > fieldset:nth-of-type(1) > div[role='group']  .invalid-feedback")).Text;

            Assert.AreEqual(GET_ERROR_MSG_USRNAME, "This is a required field.");


            string GET_ERROR_MSG_EMAIL = driver.FindElement(By.CssSelector(".col-md-4 > form > fieldset:nth-of-type(2) > div[role='group'] > .invalid-feedback")).Text;


            Assert.AreEqual(GET_ERROR_MSG_EMAIL, "This is a required field and must be a valid email address.");

            string GET_ERROR_MSG_PSWRD = driver.FindElement(By.CssSelector("fieldset:nth-of-type(5) > div[role='group'] > .invalid-feedback")).Text;

            Assert.AreEqual(GET_ERROR_MSG_PSWRD, "This is a required field and must be at least 6 characters.");


            string GET_ERROR_MSG_SCND_PSWRD = driver.FindElement(By.CssSelector("fieldset:nth-of-type(6) > div[role='group'] > .invalid-feedback")).Text;

            Assert.AreEqual(GET_ERROR_MSG_SCND_PSWRD, "This is a required field and must match password.");


        }
        public class RandomGenerator
        {
            private readonly Random _random = new Random();

            // Generates a random number within a range.      
            public int RandomNumber(int min, int max)
            {
                return _random.Next(min, max);
            }
        }
        [Test]
        public void ValidRegistration()
        {
            IWebElement MY_COMMUNITY = driver.FindElement(By.CssSelector("input[label='my-community']"));
            IWebElement ENTER_EMAIL = driver.FindElement(By.CssSelector("input[label='Email']"));
            IWebElement FIRST_NAME = driver.FindElement(By.CssSelector("input[label='First name']"));
            IWebElement LAST_NAME = driver.FindElement(By.CssSelector("input[label='Last name']"));
            IWebElement ENTER_PASSWORD = driver.FindElement(By.CssSelector("input[label='Password']"));
            IWebElement REPEAT_PASSWORD = driver.FindElement(By.CssSelector("input[label='Password Confirmation']"));
            IWebElement CREATE_COMMUNITY_BTN = driver.FindElement(By.CssSelector("button[type='submit']"));
            var generator = new RandomGenerator();
            var randomNumber = generator.RandomNumber(100000, 999999);
            string numbertostring = randomNumber.ToString();
            string today = DateTime.Now.ToString("yyyy-MM-dd");


            MY_COMMUNITY.Clear();
            ENTER_EMAIL.Clear();
            FIRST_NAME.Clear();
            LAST_NAME.Clear();
            ENTER_PASSWORD.Clear();
            REPEAT_PASSWORD.Clear();


            MY_COMMUNITY.SendKeys(numbertostring);
            FIRST_NAME.SendKeys("ha");
            LAST_NAME.SendKeys("ha");
            ENTER_EMAIL.SendKeys(numbertostring + today + "@mailinator.com");
            ENTER_PASSWORD.SendKeys("123123");
            REPEAT_PASSWORD.SendKeys("123123");
            CREATE_COMMUNITY_BTN.Click();
        }

        [Test]
        public void AlreadyRegisteredEmail()
        {
            IWebElement MY_COMMUNITY = driver.FindElement(By.CssSelector("input[label='my-community']"));
            IWebElement ENTER_EMAIL = driver.FindElement(By.CssSelector("input[label='Email']"));
            IWebElement ENTER_PASSWORD = driver.FindElement(By.CssSelector("input[label='Password']"));
            IWebElement REPEAT_PASSWORD = driver.FindElement(By.CssSelector("input[label='Password Confirmation']"));
            IWebElement CREATE_COMMUNITY_BTN = driver.FindElement(By.CssSelector("button[type='submit']"));


            MY_COMMUNITY.Clear();
            ENTER_EMAIL.Clear();
            ENTER_PASSWORD.Clear();
            REPEAT_PASSWORD.Clear();

            MY_COMMUNITY.SendKeys("fsdfsdf");
            ENTER_EMAIL.SendKeys("ivaylo@raisingthefloor.org");
            ENTER_PASSWORD.SendKeys("123123");
            REPEAT_PASSWORD.SendKeys("123123");
            CREATE_COMMUNITY_BTN.Click();

            string GET_ERROR_MSG_ALREADY_REGISTERED_EMAIL = driver.FindElement(By.CssSelector("form > div[role = 'alert']")).Text;

            Assert.AreEqual(GET_ERROR_MSG_ALREADY_REGISTERED_EMAIL, "That email address already exists!");

        }

    }
}
