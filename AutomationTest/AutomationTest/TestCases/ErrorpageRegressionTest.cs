using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
    /**
     * Acceptance tests for error page.
     */
    class ErrorpageRegressionTest
    {
        readonly IWebDriver _driver;

        readonly Navigator _navigator;

        readonly Commonpage _commonpage;
        readonly Errorpage _errorpage;

        public ErrorpageRegressionTest(IWebDriver driver)
        {
            this._driver = driver;
            _navigator = new Navigator(driver);
            _commonpage = new Commonpage(driver);
            _errorpage = new Errorpage(driver);
        }

        /**
         * Regression test for error page.
         */
        public void RegressionTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            _navigator.OpenedTheUITestingSite();

            // When I click on the Error button.
            _commonpage.ErrorButton.Click();

            // Then the title should be 404 http response code.
            StringAssert.Contains("404 Error: File not found", _driver.Title);

            // And the error message should be 404 http response code.
            StringAssert.Contains("404 Error: File not found", _errorpage.ErrorMessage.Text);
        }
    }
}
