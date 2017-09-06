using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
    /**
     * Acceptance tests for home page.
     */
    public class HomepageTest
    {
        IWebDriver driver;

        readonly Navigator _navigator;

        readonly Commonpage _commonpage;
        readonly Homepage _homepage;

        public HomepageTest(IWebDriver driver)
        {
            this.driver = driver;
            _navigator = new Navigator(driver);
            _commonpage = new Commonpage(driver);
            _homepage = new Homepage(driver);
        }

        /**
         * Regression test for home page.
         */
        public void RegressionTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            _navigator.OpenedTheUITestingSite();

            // When I click on the Home button.
            _commonpage.HomeButton.Click();

            // Then the Home button should be activated.
            Assert.AreEqual(_commonpage.HomeButtonActive.Displayed, true);
        }

        /**
         * Functional test for home page.
         */
        public void FunctionalTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            _navigator.OpenedTheUITestingSite();

            // When I click on the Home button.
            _commonpage.HomeButton.Click();

            // Then the welcome message should be the expected.
            Assert.AreEqual(_homepage.WelcomeMessage.Text, "Welcome to the Docler Holding QA Department");

            // And the description message should be the expected.
            Assert.AreEqual(_homepage.Description.Text, "This site is dedicated to perform some exercises and demonstrate automated web testing.");
        }
    }
}