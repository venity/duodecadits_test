using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTest.PageObjects
{
    class Commonpage
    {
        IWebDriver driver;

        public Commonpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".active #home")]
        public IWebElement HomeButtonActive { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement FormButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".active #form")]
        public IWebElement FormButtonActive { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement ErrorButton { get; set; }
    }
}
