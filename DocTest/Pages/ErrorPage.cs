using NUnit.Framework;
using OpenQA.Selenium;

namespace Pages
{
    class ErrorPage
    {
        public IWebDriver driver = null;

        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.FindElement(By.Id("error")).Click();
        }

        public void checkError()
        {
            Assert.True(driver.Title.Contains("404"));
        }

    }
}
