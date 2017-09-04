using OpenQA.Selenium;

namespace AutomationTest
{
    class Navigator
    {
        private const string UiTestSiteUrl = "http://uitest.duodecadits.com/";

        private IWebDriver driver;

        public void IOpenedTheUITestingSite()
        {
            NavigateTo(UiTestSiteUrl);
        }

        private void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public Navigator(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
