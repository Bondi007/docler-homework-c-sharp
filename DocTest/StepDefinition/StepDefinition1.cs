using Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

[Binding]
public class SpecFlowFeature1Steps
{

    IWebDriver driver;
    private HomePage hp;
    private FormPage fp;
    private UITestingPage uitp;
    private ErrorPage ep;

    [BeforeScenario()]
    public void Setup()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        fp = new FormPage(driver);
        hp = new HomePage(driver);
        uitp = new UITestingPage(driver);
        ep = new ErrorPage(driver);
    }

    [AfterScenario()]
    public void TearDown()
    {
        driver.Quit();
    }

    [Given(@"The user opens http://uitest\.duodecadits\.com")]
    public void GivenTheUserOpensHttpUitest_Duodecadits_Com()
    {
        driver.Url = "http://uitest.duodecadits.com";
    }

    [When(@"The user clicks on Form button in the upper Menu")]
    public void WhenTheUserClicksOnFormButtonInTheUpperMenu()
    {
        fp.GoTo();
    }

    [Then(@"The user is navigated to the Form page")]
    public void ThenTheUserIsNavigatedToTheFormPage()
    {
        Assert.AreEqual("http://uitest.duodecadits.com/form.html", driver.Url);
    }

    [Then(@"Page title is UI Testing Site")]
    public void ThenPageTitleIsUITestingSite()
    {
        Utilities.commonMethods.checkTitle(driver);
    }

    [Then(@"Company logo is displayed")]
    public void ThenCompanyLogoIsDisplayed()
    {
        Utilities.commonMethods.checkLogo(driver);
    }

    [Then(@"The user types ""(.*)"" in the input box")]
    public void ThenTheUserTypesInTheInputBox(string name)
    {
        fp.enterName(name);
    }

    [Then(@"The user clicks on Submit button")]
    public void ThenTheUserClicksOnSubmitButton()
    {
        fp.clickOnSubmit();
    }

    [When(@"The user clicks on Home button in the upper Menu")]
    public void WhenTheUserClicksOnHomeButtonInTheUpperMenu()
    {
        hp.GoTo();
    }

    [Then(@"The user is navigated to the Home page")]
    public void ThenTheUserIsNavigatedToTheHomePage()
    {
        Assert.AreEqual("http://uitest.duodecadits.com/", driver.Url);
    }

    [When(@"The user clicks on UI Testing button in the upper Menu")]
    public void WhenTheUserClicksOnUITestingButtonInTheUpperMenu()
    {
        uitp.GoTo();
    }

    [When(@"The user clicks on Error button in the upper Menu")]
    public void WhenTheUserClicksOnErrorButtonInTheUpperMenu()
    {
        ep.GoTo();
    }

    [Then(@"The user is navigated to the Error page")]
    public void ThenTheUserIsNavigatedToTheErrorPage()
    {
        Assert.AreEqual("http://uitest.duodecadits.com/error", driver.Url);
    }

    [Then(@"The user gets Error File not found message")]
    public void ThenTheUserGetsErrorFileNotFoundMessage()
    {
        ep.checkError();
    }

    [Then(@"Home menu turns to active status")]
    public void ThenHomeMenuTurnsToActiveStatus()
    {
        Utilities.commonMethods.isMenuActive(driver, "home");
    }

    [Then(@"Correct Header and Paragraph is displayed")]
    public void ThenCorrectHeaderAndParagraphIsDisplayed()
    {
        hp.checkTexts();
    }

    [Then(@"The input form and submit button is displayed")]
    public void ThenTheInputFormAndSubmitButtonIsDisplayed()
    {
        fp.checkIfFormIsDisplayed();
    }

    [Then(@"Form menu turns to active status")]
    public void ThenFormMenuTurnsToActiveStatus()
    {
        Utilities.commonMethods.isMenuActive(driver, "form");
    }

    [Then(@"Page displays Hello ""(.*)""! message")]
    public void ThenPageDisplaysHelloMessage(string name)
    {
        fp.checkName(name);
    }


}


