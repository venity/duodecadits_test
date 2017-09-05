using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTest.TestCases
{
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

        public void RegressionTest()
        {
            // I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // I click on the Home button.
            commonpage.HomeButton.Click();

            // the Home button should be activated.
            Assert.AreEqual(commonpage.HomeButtonActive.Displayed, true);
        }

        public void FunctionalTest()
        {
            // I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // I click on the Home button.
            commonpage.HomeButton.Click();

            // The welcome message should be the expected.
            Assert.AreEqual(homepage.WelcomeMessage.Text, "Welcome to the Docler Holding QA Department");

            // The description message should be the expected.
            Assert.AreEqual(homepage.Description.Text, "This site is dedicated to perform some exercises and demonstrate automated web testing.");
        }
    }
}