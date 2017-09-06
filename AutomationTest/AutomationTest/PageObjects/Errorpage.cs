using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTest.PageObjects
{
    /**
     * Page elements of the error page.
     */
    class Errorpage
    {
        IWebDriver driver;

        public Errorpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement ErrorMessage { get; set; }
    }
}
