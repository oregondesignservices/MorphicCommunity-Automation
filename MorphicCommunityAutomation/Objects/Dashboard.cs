using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace MorphicCommunityAutomation.Objects
{
    class Dashboard : SetUp
    {

        [Test]
        public void ClickCommunityBTN()
        {
            // Wait for the page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            IWebElement community_bar_plus_btn = driver.FindElement(By.CssSelector("#CommunityManager > h5:nth-child(3) > a > svg"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            community_bar_plus_btn.Click();
        }
    }
}
