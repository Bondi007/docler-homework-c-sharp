using OpenQA.Selenium;

namespace Pages
{
    class HomePage
    {
        public IWebDriver driver = null;

        static string HEADER = "Welcome to the Docler Holding QA Department";
        static string PARAGRAPH = "This site is dedicated to perform some exercises and demonstrate automated web testing.";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.FindElement(By.Id("home")).Click();
        }

        public void checkTexts()
        {
            driver.FindElement(By.XPath(".//h1[contains(text(),'" + HEADER + "')]"));
            driver.FindElement(By.XPath(".//p[contains(text(),'" + PARAGRAPH + "')]"));
        }



    }
}
