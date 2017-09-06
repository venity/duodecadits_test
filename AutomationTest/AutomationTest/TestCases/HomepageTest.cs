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

        Navigator navigator;

        Commonpage commonpage;
        Homepage homepage;

        public HomepageTest(IWebDriver driver)
        {
            this.driver = driver;
            navigator = new Navigator(driver);
            commonpage = new Commonpage(driver);
            homepage = new Homepage(driver);
        }

        /**
         * Regression test for home page.
         */
        public void RegressionTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // When I click on the Home button.
            commonpage.HomeButton.Click();

            // Then the Home button should be activated.
            Assert.AreEqual(commonpage.HomeButtonActive.Displayed, true);
        }

        /**
         * Functional test for home page.
         */
        public void FunctionalTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // When I click on the Home button.
            commonpage.HomeButton.Click();

            // Then the welcome message should be the expected.
            Assert.AreEqual(homepage.WelcomeMessage.Text, "Welcome to the Docler Holding QA Department");

            // And the description message should be the expected.
            Assert.AreEqual(homepage.Description.Text, "This site is dedicated to perform some exercises and demonstrate automated web testing.");
        }
    }
}