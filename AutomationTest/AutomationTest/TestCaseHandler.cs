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
        public void CommonpageTestCase()
        {
            new CommonTest(driver).SmokeTest();
        }

        [Test]
        public void HomepageTestCase()
        {
            HomepageTest homepage = new HomepageTest(driver);
            homepage.RegressionTest();
            homepage.RegressionTest();
        }

        [Test]
        public void FormpageTestCase()
        {
            FormpageTest formpage = new FormpageTest(driver);
            formpage.RegressionTest();
            formpage.FunctionalTest();
        }

        [Test]
        public void ErrorpageTestCase()
        {
            ErrorpageRegressionTest errorpage = new ErrorpageRegressionTest(driver);
            errorpage.RegressionTest();
        }



        [TearDown]
        public void TestEnd()
        {
            driver.Close();
        }
    }
}
