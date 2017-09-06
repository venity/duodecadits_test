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

        Navigator navigator;

        Commonpage commonpage;
        Formpage formpage;
        Homepage homepage;

        public FormpageTest(IWebDriver driver)
        {
            this.driver = driver;
            navigator = new Navigator(driver);
            commonpage = new Commonpage(driver);
            formpage = new Formpage(driver);
            homepage = new Homepage(driver);
        }

        /**
         * Regression test for form page.
         */
        public void RegressionTest()
        {
            // Given I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // When I click on the Form button
            commonpage.FormButton.Click();

            // Then the Form button should be activated
            Assert.AreEqual(commonpage.FormButtonActive.Displayed, true);
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
                navigator.OpenedTheUITestingSite();

                // When I click on the Form button
                commonpage.FormButton.Click();

                // Then the input field should be visible
                Assert.AreEqual(formpage.InputField.Displayed, true);

                // And the submit field should be visible
                Assert.AreEqual(formpage.SubmitButton.Displayed, true);

                // When I type <Name> the input field
                formpage.InputField.SendKeys(userData.Key);

                // And I click on the submit button
                formpage.SubmitButton.Click();

                // Then he following text should appear and equal to <Expected Message>
                Assert.AreEqual(homepage.WelcomeMessage.Displayed, true);
                Assert.AreEqual(homepage.WelcomeMessage.Text, userData.Value);
            }
        }
    }
}
