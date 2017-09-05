using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTest.PageObjects
{
    class Homepage
    {
        IWebDriver driver;

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".ui-test h1")]
        public IWebElement WelcomeMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".ui-test .lead")]
        public IWebElement Description { get; set; }

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
