using NUnit.Framework;
using OpenQA.Selenium;

namespace Pages
{
    class FormPage
    {
        public IWebDriver driver = null;

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.FindElement(By.Id("form")).Click();
        }

        public void checkIfFormIsDisplayed()
        {
            Assert.AreEqual(true, driver.FindElement(By.Id("hello-input")).Displayed);
            Assert.AreEqual(true, driver.FindElement(By.Id("hello-submit")).Displayed);
        }

        public void enterName(string name)
        {
            driver.FindElement(By.Id("hello-input")).Clear();
            driver.FindElement(By.Id("hello-input")).SendKeys(name);
        }

        public void clickOnSubmit()
        {
            driver.FindElement(By.Id("hello-submit")).Click();
        }

        public void checkName(string name)
        {
            Assert.AreEqual("http://uitest.duodecadits.com/hello.html?myName=" + name, driver.Url);
            string helloText = driver.FindElement(By.XPath(".//*[@id='hello-text']")).Text;
            Assert.AreEqual("Hello " + name + "!", helloText);
        }



    }
}
