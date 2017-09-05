using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
    class ErrorpageRegressionTest
    {
        IWebDriver driver;

        Navigator navigator;

        Commonpage commonpage;
        Errorpage errorpage;

        public ErrorpageRegressionTest(IWebDriver driver)
        {
            this.driver = driver;
            navigator = new Navigator(driver);
            commonpage = new Commonpage(driver);
            errorpage = new Errorpage(driver);
        }

        public void RegressionTest()
        {
            // I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // I click on the Error button
            commonpage.ErrorButton.Click();

            // I should get an error message with 404 http response code
            StringAssert.Contains("404 Error: File not found", driver.Title);
            StringAssert.Contains("404 Error: File not found", errorpage.ErrorMessage.Text);
        }
    }
}
