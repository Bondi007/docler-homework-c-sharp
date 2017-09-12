using OpenQA.Selenium;

namespace Pages
{
    class UITestingPage
    {
        public IWebDriver driver = null;

        public UITestingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.FindElement(By.Id("site")).Click();
        }


    }
}
