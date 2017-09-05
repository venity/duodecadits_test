using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
    class FormpageTest
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

            // the Home button should be activated
            commonPageObject.FormButton.Click();

            // I should get navigated to the Home page
            Assert.AreEqual(commonPageObject.FormButtonActive.Displayed, true);
        }
    }
}
