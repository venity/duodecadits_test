using AutomationTest.PageObjects;
using AutomationTest.TestCases;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationTest
{
    class TestCaseHandler
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver("c:/");
        }

        [Test]
        public void TestApp()
        {
           // new SmokeTest().start(driver);
           // new HomepageTest().start(driver);
            // new FormpageTest().start(driver);
            new ErrorpageRegressionTest().startRestAssuredTest(driver);
        }

        [TearDown]
        public void TestEnd()
        {
            driver.Close();
        }
    }
}
