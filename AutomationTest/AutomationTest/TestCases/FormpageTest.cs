using AutomationTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutomationTest.TestCases
{
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

        public void RegressionTest()
        {
            // I opened the http://uitest.duodecadits.com url.
            navigator.OpenedTheUITestingSite();

            // I click on the Form button
            commonpage.FormButton.Click();

            // The Form button should be activated
            Assert.AreEqual(commonpage.FormButtonActive.Displayed, true);
        }

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
                // I opened the http://uitest.duodecadits.com url.
                navigator.OpenedTheUITestingSite();

                // I click on the Form button
                commonpage.FormButton.Click();

                // The input field should be visible
                Assert.AreEqual(formpage.InputField.Displayed, true);

                // The submit field should be visible
                Assert.AreEqual(formpage.SubmitButton.Displayed, true);

                // I type <Name> the input field
                formpage.InputField.SendKeys(userData.Key);

                // I click on the submit button
                formpage.SubmitButton.Click();

                // The following text should appear and equal to <Expected Message>
                Assert.AreEqual(homepage.WelcomeMessage.Text, userData.Value);
            }
        }
    }
}
