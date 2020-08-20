using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace MorphicCommunityAutomation.Objects
{
    class SetUp
    {

        public static IWebDriver driver = new ChromeDriver();

        public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        public void Initialize()
        {

            driver.Navigate().GoToUrl("http://localhost:8080/#/");
            driver.Manage().Window.Maximize();
        }

    }
}
