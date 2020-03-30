namespace QAAutomation_Exam_2.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using QAAutomation_Exam_2.Pages.AccordionPage;
    using QAAutomation_Exam_2.Pages.CostumizeIconsPage;
    using QAAutomation_Exam_2.Pages.MainPage;
    using System;
    using System.IO;
    using System.Reflection;

    [TestFixture]
    public class Task_2
    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private AccordionPage _accordionPage;
        private CostumizeIconsPage _customizeIconsPage;

        [SetUp]
        public void SetUp()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");

            _driver = new ChromeDriver(path, options);
            _mainPage = new MainPage(_driver);
            _accordionPage = new AccordionPage(_driver);
            _customizeIconsPage = new CostumizeIconsPage(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            string name = TestContext.CurrentContext.Test.Name;
            string fileFullPath = String.Format(@"..\..\..\Screenshots\{0}.png", name);
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                TakeScreenshot(_driver, fileFullPath);
            }

            _driver.Quit();
        }

        [Test]
        public void ToggleIconsTest()
        {
            _mainPage.NavigateTo();
            _mainPage.GoToAccordionPage();
            _accordionPage.GoToCustomizeIconsPage();
            bool allToggleIconsDisplayed;

            // Icons OFF
            _customizeIconsPage.ClickToggleButton();

            allToggleIconsDisplayed = _customizeIconsPage.AreAllToggleIconsDisplayed();
            Assert.False(allToggleIconsDisplayed);

            // Icons ON
            _customizeIconsPage.ClickToggleButton();

            allToggleIconsDisplayed = _customizeIconsPage.AreAllToggleIconsDisplayed();
            Assert.True(allToggleIconsDisplayed);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void ExpandSectionTest(int sectionIndex)
        {
            _mainPage.NavigateTo();
            _mainPage.GoToAccordionPage();
            _accordionPage.GoToCustomizeIconsPage();

            _customizeIconsPage.ClickOnSection(sectionIndex);

            bool result = _customizeIconsPage.IsCorrectSectionExpanded(sectionIndex);
            Assert.True(result);
        }

        private void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}
