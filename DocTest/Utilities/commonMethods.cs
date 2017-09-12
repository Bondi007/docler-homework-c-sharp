using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class commonMethods
    {
        public static void checkTitle(IWebDriver driver)
        {
            Assert.AreEqual("UI Testing Site", driver.Title);
        }

        public static void checkLogo(IWebDriver driver)
        {
            Assert.AreEqual(true, driver.FindElement(By.Id("dh_logo")).Displayed);
        }

        public static void isMenuActive(IWebDriver driver, string pageName)
        {
            driver.FindElement(By.XPath(".//*[@class='active']/a[@id='" + pageName + "']"));
        }
    }
}
