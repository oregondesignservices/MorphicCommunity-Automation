﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MorphicCommunityAutomation.Objects
{
    class MorphicbarEditor : SetUp
    {

        [Test]
        public void AddAllButtons()
        {
            // Add Gmail
            IWebElement gmail = driver.FindElement(By.CssSelector("ul:nth-of-type(1) > div > li:nth-of-type(1) > a[target='_self']"));
            gmail.Click();
            IWebElement leftarrowbtn = driver.FindElement(By.CssSelector("div#preview-bar a[target='_self'] > svg[alt='icon']"));
            leftarrowbtn.Click();
            IWebElement addtodrawer = driver.FindElement(By.CssSelector("div#preview-drawer  .btn.btn-block.btn-sm.btn-success.mb-3"));
            addtodrawer.Click();

            // Add Outlook
            IWebElement outlook = driver.FindElement(By.CssSelector("ul:nth-of-type(1) > div > li:nth-of-type(2) > a[target='_self']"));
            outlook.Click();
            IWebElement secondaddtodrawer = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer.Click();

            // Add Yahoo mail
            IWebElement yahoo = driver.FindElement(By.CssSelector("ul:nth-of-type(1) > div > li:nth-of-type(3) > a[target='_self']"));
            yahoo.Click();
            IWebElement secondaddtodrawer1 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer1.Click();



            // Add AOL mail
            IWebElement aol = driver.FindElement(By.CssSelector("ul:nth-of-type(1) > div > li:nth-of-type(4) > a[target='_self']"));
            aol.Click();
            IWebElement secondaddtodrawer2 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer2.Click();


            // Predifined buttons 

            // Add Reddit
            IWebElement reddit = driver.FindElement(By.CssSelector("ul:nth-of-type(2) > div > li:nth-of-type(1) > a[target='_self']"));
            reddit.Click();

            IWebElement secondaddtodrawer10 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer10.Click();


            // Add Facebook
            IWebElement facebook = driver.FindElement(By.CssSelector("ul:nth-of-type(2) > div > li:nth-of-type(2) > a[target='_self']"));
            facebook.Click();
            IWebElement secondaddtodrawer3 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer3.Click();

            // Add Skype
            IWebElement skype = driver.FindElement(By.CssSelector("ul:nth-of-type(2) > div > li:nth-of-type(3) > a[target='_self']"));
            skype.Click();

            IWebElement secondaddtodrawer4 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer4.Click();


            // Add Telegram
            IWebElement telegram = driver.FindElement(By.CssSelector("ul:nth-of-type(2) > div > li:nth-of-type(4) > a[target='_self']"));
            telegram.Click();
            IWebElement secondaddtodrawer5 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer5.Click();


            // Add Viber
            IWebElement viber = driver.FindElement(By.CssSelector("ul:nth-of-type(2) > div > li:nth-of-type(5) > a[target='_self']"));
            viber.Click();
            IWebElement secondaddtodrawer6 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer6.Click();


            // Add Task Manager
            IWebElement taskManager = driver.FindElement(By.CssSelector("div > li:nth-of-type(6) > a[target='_self']"));
            taskManager.Click();
            IWebElement secondaddtodrawer7 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer7.Click();


            // Add Screenshot
            IWebElement screenshot = driver.FindElement(By.CssSelector("li:nth-of-type(7) > a[target='_self']"));
            screenshot.Click();

            IWebElement secondaddtodrawer8 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer8.Click();


            // Add Magnifier
            IWebElement magnifier = driver.FindElement(By.CssSelector("li:nth-of-type(8) > a[target='_self']"));
            magnifier.Click();

            IWebElement secondaddtodrawer9 = driver.FindElement(By.CssSelector("#preview-drawer > div > button"));
            secondaddtodrawer9.Click();

        }

        public void ChangeCommunityBarName()
        {
            IWebElement communitybarname = driver.FindElement(By.Id("barName"));
            communitybarname.Clear();
            communitybarname.SendKeys("Name name name");
            // Save bar name
            IWebElement savecommunitybar = driver.FindElement(By.CssSelector("#editorNav > button"));
            savecommunitybar.Click();
            /*            driver.Navigate().Refresh();*/
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#BarsList > ul > li:nth-child(2) > a")));
            wait.Until(driver => By.CssSelector("#BarsList > ul > li:nth-child(2) > a"));
            IWebElement nameofcommunitybar = driver.FindElement(By.CssSelector("#BarsList > ul > li:nth-child(2) > a"));
            string getnameofnewcommunitybar = nameofcommunitybar.Text;
            Assert.AreEqual(getnameofnewcommunitybar, "Name name name");
        }

        public void RemoveCommunityBarName()
        {
            IWebElement communitybarname = driver.FindElement(By.CssSelector("div#BarsList > ul > li:nth-of-type(2) > a"));
            communitybarname.Click();
            // Save bar name
            IWebElement remove_btn = driver.FindElement(By.CssSelector("li#removeBar > a[role='button']"));
            remove_btn.Click();

            IWebElement cancel_btn = driver.FindElement(By.CssSelector("footer#barDeleteConfirm___BV_modal_footer_ > .btn.btn-secondary"));
            cancel_btn.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            IWebElement nameofcommunitybar = driver.FindElement(By.CssSelector("#BarsList > ul > li:nth-child(2) > a"));
            string getnameofnewcommunitybar = nameofcommunitybar.Text;
            Assert.AreEqual(getnameofnewcommunitybar, "Name name name");

            bool staleElement = true;
            while (staleElement)
            {
                try
                {
                    driver.FindElement(By.CssSelector("footer#barDeleteConfirm___BV_modal_footer_ > .btn.btn-primary")).Click();
                    staleElement = false;

                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            wait.Until(driver => By.CssSelector("footer#barDeleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("footer#barDeleteConfirm___BV_modal_footer_ > .btn.btn-primary")));

            IWebElement remove_rmv_button = driver.FindElement(By.CssSelector("footer#barDeleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            remove_rmv_button.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public void ChangeRoleOnFirstInvitedPerson()
        {
            bool staleElement = true;
            while (staleElement)
            {
                try
                {
                    driver.FindElement(By.CssSelector("div#MembersList > ul > li:nth-of-type(1) > a")).Click();
                    staleElement = false;

                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
            wait.Until(driver => By.CssSelector("#MembersList > ul > li:nth-child(2) > a"));
            IWebElement selectFirstPerson = driver.FindElement(By.CssSelector("#MembersList > ul > li:nth-child(1) > a"));
            selectFirstPerson.Click();

            IWebElement selectUserDetails = driver.FindElement(By.CssSelector("ul#editorNav span"));
            selectUserDetails.Click();

            string NAME_OF_FIRST_PERSON = driver.FindElement(By.CssSelector(".bg-light.p-3 b")).Text;
            Assert.AreEqual(NAME_OF_FIRST_PERSON, "Ivan Petrov");
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            while (staleElement)
            {
                try
                {
                    driver.FindElement(By.CssSelector("li:nth-of-type(1) > a[role='button']")).Click();
                    staleElement = false;

                }
                catch (StaleElementReferenceException e)
                {
                    staleElement = true;
                }
            }
            string ROLE = driver.FindElement(By.CssSelector("li:nth-of-type(1) > a[role='button']")).Text;
            Assert.AreEqual(ROLE, "Make user a Community Manager");
            IWebElement MAKE_COMMUNITY_MANAGER = driver.FindElement(By.CssSelector("li:nth-of-type(1) > a[role='button']"));
            MAKE_COMMUNITY_MANAGER.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("footer#roleChangeConfirm___BV_modal_footer_ > .btn.btn-primary"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("footer#roleChangeConfirm___BV_modal_footer_ > .btn.btn-primary")));


            IWebElement CHANGE_ROLE = driver.FindElement(By.CssSelector("footer#roleChangeConfirm___BV_modal_footer_ > .btn.btn-primary"));
            CHANGE_ROLE.Click();

            string CHANGED_ROLE = driver.FindElement(By.CssSelector("li:nth-of-type(1) > a[role='button']")).Text;
            Assert.AreEqual(CHANGED_ROLE, "Remove community manager role from user");
        }
        public void RemoveFirstInvitedPerson()
        {

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("li:nth-of-type(2) > a[role='button']"));

            IWebElement DELETE_USER = driver.FindElement(By.CssSelector("li:nth-of-type(2) > a[role='button']"));
            DELETE_USER.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary")));
            IWebElement DELETE_BTN = driver.FindElement(By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            DELETE_BTN.Click();

        }

        public void RemoveSecondInvitedPerson()
        {
            driver.Navigate().Refresh();
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("#MembersList > ul > li:nth-child(1) > a"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#MembersList > ul > li:nth-child(1) > a")));


            IWebElement SECOND_INVITED_PERSON1 = driver.FindElement(By.CssSelector("div#MembersList a"));
            SECOND_INVITED_PERSON1.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("span"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span")));


            IWebElement USER_DETAILS = driver.FindElement(By.CssSelector("span"));
            USER_DETAILS.Click();


            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("li:nth-of-type(2) > a[role='button']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("li:nth-of-type(2) > a[role='button']")));


            IWebElement DELETE_USER = driver.FindElement(By.CssSelector("li:nth-of-type(2) > a[role='button']"));
            DELETE_USER.Click();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            wait.Until(driver => By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary")));

            IWebElement DELETE_BTN1 = driver.FindElement(By.CssSelector("footer#deleteConfirm___BV_modal_footer_ > .btn.btn-primary"));
            DELETE_BTN1.Click();
        }
    }
}
