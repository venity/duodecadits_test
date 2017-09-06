using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
    /**
     * Acceptance tests for common pages.
     */
    class CommonTest
    {
        readonly IWebDriver _driver;

        readonly Commonpage _commonpage;
        readonly Navigator _navigator;

        public CommonTest(IWebDriver driver)
        {
            this._driver = driver;
            _navigator = new Navigator(driver);
            _commonpage = new Commonpage(driver);
        }

        /**
         * Smoke test for common pages.
         */
        public void SmokeTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            _navigator.OpenedTheUITestingSite();

            // When I click on the Homepage button.
            _commonpage.HomeButton.Click();

            // Then the title should be UI Testing Site.
            Assert.AreEqual(_driver.Title, "UI Testing Site");
            
            // And the company logo should be visible.
            Assert.AreEqual(_commonpage.Logo.Displayed, true);

            // When I click on the Form button.
            _commonpage.FormButton.Click();

            // Then the title should be UI Testing Site.
            Assert.AreEqual(_driver.Title, "UI Testing Site");

            // And the company logo should be visible.
            Assert.AreEqual(_commonpage.Logo.Displayed, true);
        }
    }
}
