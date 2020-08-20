using NUnit.Framework;
using OpenQA.Selenium;

namespace MorphicCommunityAutomation.Objects
{
    class MorphicbarPreconfigured : SetUp
    {

        [Test]
        public void StartCustomizingFirstBar()
        {
            IWebElement first_start_customizing_bar = driver.FindElement(By.CssSelector("div:nth-of-type(1) > .bg-silver.p-3.rounded > .btn.btn-block.btn-primary"));
            first_start_customizing_bar.Click();
        }
        [Test]
        public void StartCustomizingSecondBar()
        {
            IWebElement second_start_customizing_bar = driver.FindElement(By.CssSelector("div:nth-of-type(2) > .bg-silver.p-3.rounded > .btn.btn-block.btn-primary"));
            second_start_customizing_bar.Click();
        }

        [Test]
        public void StartCustomizingThirdBar()
        {
            IWebElement third_start_customizing_bar = driver.FindElement(By.CssSelector("div:nth-of-type(3) > .bg-silver.p-3.rounded > .btn.btn-block.btn-primary"));
            third_start_customizing_bar.Click();
        }

        [Test]
        public void StartCustomizingFourthBar()
        {
            IWebElement fourth_start_customizing_bar = driver.FindElement(By.CssSelector("div:nth-of-type(4) > .bg-silver.p-3.rounded > .btn.btn-block.btn-primary"));
            fourth_start_customizing_bar.Click();
        }

        [Test]
        public void StartCustomizingEmptyBar()
        {
            IWebElement customize_empty_bar = driver.FindElement(By.CssSelector(".text-right [target]"));
            customize_empty_bar.Click();
        }
    }
}
