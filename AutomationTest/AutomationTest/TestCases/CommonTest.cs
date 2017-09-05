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
    class CommonTest
    {
        IWebDriver driver;

        Commonpage commonpage;
        Navigator navigator;

        public CommonTest(IWebDriver driver)
        {
            this.driver = driver;
            navigator = new Navigator(driver);
            commonpage = new Commonpage(driver);
        }

        public void SmokeTest()
        {
            // I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // When I click on the Homepage button
            commonpage.HomeButton.Click();

            // Then the title should be UI Testing Site
            Assert.AreEqual(driver.Title, "UI Testing Site");
            
            // And the company logo should be visible
            Assert.AreEqual(commonpage.Logo.Displayed, true);

            // When I click on the Form button
            commonpage.FormButton.Click();

            // Then the title should be UI Testing Site
            Assert.AreEqual(driver.Title, "UI Testing Site");

            // And the company logo should be visible
            Assert.AreEqual(commonpage.Logo.Displayed, true);
        }
    }
}
