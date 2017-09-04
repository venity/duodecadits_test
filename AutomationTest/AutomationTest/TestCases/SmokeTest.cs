using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.TestCases
{
    class SmokeTest
    {
        Common commonPageObject;
        Navigator navigator;

        public void start(IWebDriver driver)
        {
            // Initialize
            navigator = new Navigator(driver);
            commonPageObject = new Common(driver);

            // I opened the http://uitest.duodecadits.com url.
            navigator.IOpenedTheUITestingSite();

            // When I click on the Homepage button
            commonPageObject.HomeButton.Click();

            // Then the title should be UI Testing Site
            Assert.AreEqual(driver.Title, "UI Testing Site");
            
            // And the company logo should be visible
            Assert.AreEqual(commonPageObject.Logo.Displayed, true);

            // When I click on the Form button
            commonPageObject.FormButton.Click();

            // Then the title should be UI Testing Site
            Assert.AreEqual(driver.Title, "UI Testing Site");

            // And the company logo should be visible
            Assert.AreEqual(commonPageObject.Logo.Displayed, true);
        }

        private void TheHomeButtonShouldBeActive()
        {
            Assert.AreEqual(commonPageObject.HomeButton.GetCssValue("class"), true);
        }
    }
}
