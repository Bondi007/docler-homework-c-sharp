using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    class FormPage
    {
        public IWebDriver driver = null;

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "hello-input")]
        private IWebElement inputField;

        [FindsBy(How = How.Id, Using = "hello-submit")]
        private IWebElement submitButton;

        public void GoTo()
        {
            driver.FindElement(By.Id("form")).Click();
        }

        public void checkIfFormIsDisplayed()
        {
            Assert.AreEqual(true, inputField.Displayed);
            Assert.AreEqual(true, submitButton.Displayed);
        }

        public void enterName(string name)
        {
            inputField.Clear();
            inputField.SendKeys(name);
        }

        public void clickOnSubmit()
        {
            submitButton.Click();
        }

        public void checkName(string name)
        {
            Assert.AreEqual("http://uitest.duodecadits.com/hello.html?myName=" + name, driver.Url);
            string helloText = driver.FindElement(By.XPath(".//*[@id='hello-text']")).Text;
            Assert.AreEqual("Hello " + name + "!", helloText);
        }



    }
}
