using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomationTest.TestCases
{
    /**
     * Acceptance tests for form page.
     */
    class FormpageTest
    {
        IWebDriver driver;

        readonly Navigator _navigator;

        readonly Commonpage _commonpage;
        readonly Formpage _formpage;
        readonly Homepage _homepage;

        public FormpageTest(IWebDriver driver)
        {
            this.driver = driver;
            _navigator = new Navigator(driver);
            _commonpage = new Commonpage(driver);
            _formpage = new Formpage(driver);
            _homepage = new Homepage(driver);
        }

        /**
         * Regression test for form page.
         */
        public void RegressionTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            _navigator.OpenedTheUITestingSite();

            // When I click on the Form button
            _commonpage.FormButton.Click();

            // Then the Form button should be activated
            Assert.AreEqual(_commonpage.FormButtonActive.Displayed, true);
        }

        /**
         * Functional test for form page.
         */
        public void FunctionalTest()
        {
            // Test data
            Dictionary<string, string> usersData = new Dictionary<string, string>();
            usersData.Add("John", "Hello John!");
            usersData.Add("Sophia", "Hello Sophia!");
            usersData.Add("Charlie", "Hello Charlie!");
            usersData.Add("Emily", "Hello Emily!");

            foreach (KeyValuePair<string, string> userData in usersData)
            {
                // Given I opened the http://uitest.duodecadits.com url.
                _navigator.OpenedTheUITestingSite();

                // When I click on the Form button
                _commonpage.FormButton.Click();

                // Then the input field should be visible
                Assert.AreEqual(_formpage.InputField.Displayed, true);

                // And the submit field should be visible
                Assert.AreEqual(_formpage.SubmitButton.Displayed, true);

                // When I type <Name> the input field
                _formpage.InputField.SendKeys(userData.Key);

                // And I click on the submit button
                _formpage.SubmitButton.Click();

                // Then he following text should appear and equal to <Expected Message>
                Assert.AreEqual(_homepage.WelcomeMessage.Displayed, true);
                Assert.AreEqual(_homepage.WelcomeMessage.Text, userData.Value);
            }
        }
    }
}
