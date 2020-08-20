using NUnit.Framework;
using OpenQA.Selenium;

namespace MorphicCommunityAutomation.Objects
{
    class MemberInvite : SetUp
    {
        [Test]
        public void CheckEmptyFields()
        {
            IWebElement INVITE = driver.FindElement(By.CssSelector("h5:nth-of-type(2) > .icon-add > svg[alt='icon']"));
            INVITE.Click();

            IWebElement NEXT = driver.FindElement(By.CssSelector("form .btn-primary"));
            NEXT.Click();

            string INVLD_FIRST_NAME = driver.FindElement(By.CssSelector("div#first-name  .invalid-feedback")).Text;
            Assert.AreEqual(INVLD_FIRST_NAME, "This is a required field.");

            string INVLD_EMAIL = driver.FindElement(By.CssSelector("div#member-email  .invalid-feedback")).Text;
            Assert.AreEqual(INVLD_EMAIL, "This is a required field and must be a valid email address.");

            IWebElement CANCEL_BTN = driver.FindElement(By.CssSelector("a[href='#/dashboard']"));
            CANCEL_BTN.Click();

           
        }
    }
}
