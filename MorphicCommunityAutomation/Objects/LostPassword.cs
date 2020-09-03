
using NUnit.Framework;
using OpenQA.Selenium;

namespace MorphicCommunityAutomation.Objects
{
    class LostPassword : SetUp
    {
        [Test]
        public void CheckLostPassword()
        {

            /*            driver.Navigate().GoToUrl("http://localhost:8080/#/");
                        IWebElement LOST_PASSWORD = driver.FindElement(By.CssSelector("form > .btn.btn-success.ml-1"));

                        LOST_PASSWORD.Click();

                        IWebElement EMAIL = driver.FindElement(By.TagName("input"));
                        EMAIL.SendKeys("ivaylo@raisingthefloor.org");
                        IWebElement RST_PSWRD = driver.FindElement(By.CssSelector("body > div > div.jumbotron.bg-light > div > div > form > div > div:nth-child(1) > button"));
                        RST_PSWRD.Click();


                        string CNNTN_ERROR = driver.FindElement(By.CssSelector("body > div > div.jumbotron.bg-light > div > div.col-md-7 > form > div")).Text;
                        Assert.AreEqual(CNNTN_ERROR, "Network error, cannot connect to the server! Please check your internet connection.");*/
        }
        [Test]
        public void InvalidEmail()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/#/reset-password");
            driver.Navigate().Refresh();
            IWebElement EMAIL = driver.FindElement(By.TagName("input"));
            EMAIL.SendKeys("dsadasd");


            string INVLD_EMAIL_ERROR = driver.FindElement(By.ClassName("invalid-feedback")).Text;
            Assert.AreEqual(INVLD_EMAIL_ERROR, "This is a required field and must be a valid email address.");
        }
    }
}
