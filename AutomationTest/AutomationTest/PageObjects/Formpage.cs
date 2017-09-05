using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTest.PageObjects
{
    class Formpage
    {
        IWebDriver driver;

        public Formpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement InputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement SubmitButton { get; set; }
    }
}
