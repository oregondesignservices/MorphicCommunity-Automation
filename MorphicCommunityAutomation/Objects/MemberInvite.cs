using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

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

        [Test]
        public void AddMember()
        {

            IWebElement INVITE = driver.FindElement(By.CssSelector("h5:nth-of-type(2) > .icon-add > svg[alt='icon']"));
            INVITE.Click();


            IWebElement NAME = driver.FindElement(By.CssSelector("input#firstName"));
            NAME.SendKeys("Ivan Petrov");

            IWebElement EMAIL = driver.FindElement(By.CssSelector("input#memberEmail"));
            EMAIL.SendKeys("dadasdas@dasd.ag");

            IWebElement NEXT = driver.FindElement(By.CssSelector("form .btn-primary"));
            NEXT.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("p:nth-of-type(1) > b"));

            string GET_NAME = driver.FindElement(By.CssSelector("p:nth-of-type(1) > b")).Text;

            Assert.AreEqual(GET_NAME, "Ivan Petrov");

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("p:nth-of-type(2) > b"));

            string GET_EMAIL = driver.FindElement(By.CssSelector("p:nth-of-type(2) > b")).Text;

            Assert.AreEqual(GET_EMAIL, "dadasdas@dasd.ag");


            /*            IWebElement ADD_MEMBER_BTN = driver.FindElement(By.CssSelector("div:nth-of-type(1) > button:nth-of-type(2)"));
                        ADD_MEMBER_BTN.Click();

                        IWebElement CANCEL_ADD_MEMBER_BTN = driver.FindElement(By.CssSelector("footer#memberConfirm___BV_modal_footer_ > .btn.btn-secondary"));
                        CANCEL_ADD_MEMBER_BTN.Click();*/

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("div:nth-of-type(1) > button:nth-of-type(2)"));

            IWebElement ADD_MEMBER_BTN = driver.FindElement(By.CssSelector("div:nth-of-type(1) > button:nth-of-type(2)"));
            ADD_MEMBER_BTN.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("#memberConfirm___BV_modal_footer_ > button.btn.btn-primary"));

            IWebElement ADD_MEMBER_ADD_MEMBER_BTN = wait.Until(e => e.FindElement(By.CssSelector("#memberConfirm___BV_modal_footer_ > button.btn.btn-primary")));

            action.MoveToElement(driver.FindElement(By.CssSelector("#memberConfirm___BV_modal_footer_ > button.btn.btn-primary"))).Perform();

            /*            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);*/
            /*            wait.Until( driver => By.CssSelector("#memberConfirm___BV_modal_footer_ > button.btn.btn-primary"));*/
            /*ADD_MEMBER_ADD_MEMBER_BTN.SendKeys(Keys.Enter);*/
            ADD_MEMBER_ADD_MEMBER_BTN.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("div#MembersList a"));

            string GET_PERSON_NAME = driver.FindElement(By.CssSelector("div#MembersList a")).Text;

            Assert.AreEqual(GET_PERSON_NAME, "Ivan Petrov");
        }
        [Test]
        public void AddMemberAndSendInvitation()
        {

            IWebElement INVITE = driver.FindElement(By.CssSelector("h5:nth-of-type(2) > .icon-add > svg[alt='icon']"));
            INVITE.Click();


            IWebElement NAME = driver.FindElement(By.CssSelector("input#firstName"));
            NAME.SendKeys("Martin Angelove");

            IWebElement EMAIL = driver.FindElement(By.CssSelector("input#memberEmail"));
            EMAIL.SendKeys("bau@au.mu");

            IWebElement NEXT = driver.FindElement(By.CssSelector("form .btn-primary"));
            NEXT.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("p > p:nth-child(2) > b"));

            string GET_NAME = driver.FindElement(By.CssSelector("p > p:nth-child(2) > b")).Text;

            Assert.AreEqual(GET_NAME, "Martin Angelove");

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("p > p:nth-child(3) > b"));

            string GET_EMAIL = driver.FindElement(By.CssSelector("p > p:nth-child(3) > b")).Text;

            Assert.AreEqual(GET_EMAIL, "bau@au.mu");

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("div:nth-of-type(1) > button:nth-of-type(3)"));

            IWebElement ADD_MEMBER_BTN_SEND_EMAIL = driver.FindElement(By.CssSelector("div:nth-of-type(1) > button:nth-of-type(3)"));
            ADD_MEMBER_BTN_SEND_EMAIL.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary")));
            wait.Until(driver => By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary"));

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

            /*action.Click(driver.FindElement(By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary")).Click();*/

            bool staleElement = true;
            while (staleElement)
            {
                try
                {
                    driver.FindElement(By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary")).Click();
                    staleElement = false;

                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
            IWebElement SEND_INVITE_BTN = driver.FindElement(By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary"));
/*            action.MoveToElement(driver.FindElement(By.CssSelector("footer#inviteConfirm___BV_modal_footer_ > .btn.btn-primary"))).Click().Build().Perform();*/
            /*SEND_INVITE_BTN.Click();*/

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("li:nth-of-type(3) > a"));

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(1);
            string GET_PERSON_NAME = driver.FindElement(By.CssSelector("li:nth-of-type(3) > a")).Text;

            Assert.AreEqual(GET_PERSON_NAME, "Martin Angelove");
        }
    }
}
