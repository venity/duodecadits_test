using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.PageObjects;
using OpenQA.Selenium;
using RA;
using static NUnit.Framework.StringAssert;

namespace AutomationTest.TestCases
{
    class ErrorpageRegressionTest
    {
        Common commonPageObject;
        Navigator navigator;

        public void startSeleniumTest(IWebDriver driver)
        {
            // Initialize
            navigator = new Navigator(driver);
            commonPageObject = new Common(driver);

            // I opened the http://uitest.duodecadits.com url.
            navigator.IOpenedTheUITestingSite();

            // the Home button should be activated
            commonPageObject.ErrorButton.Click();

            // I should get navigated to the Home page
            Contains("404 Error: File not found", driver.Title);
        }

        public void startRestAssuredTest(IWebDriver driver)
        {
            // Initialize
            navigator = new Navigator(driver);
            commonPageObject = new Common(driver);

            // I opened the http://uitest.duodecadits.com url.
            navigator.IOpenedTheUITestingSite();

            // the Home button should be activated
            commonPageObject.ErrorButton.Click();

            // I should get navigated to the Home page
            Contains("404 Error: File not found", driver.Title);
        }
    }
}
