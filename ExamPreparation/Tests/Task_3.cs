namespace QAAutomation_Exam_2.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using QAAutomation_Exam_2.Pages.ArticleNavigationPage;
    using QAAutomation_Exam_2.Pages.ArticlePage;
    using QAAutomation_Exam_2.Pages.MicrosoftDocsMainPage;
    using QAAutomation_Exam_2.Pages.TreePage;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text;

    [TestFixture]
    public class Task_3
    {
        private IWebDriver _driver;
        private MicrosoftDocsMainPage _microsoftDocsMainPage;
        private TreePage _treePage;
        private ArticleNavigationPage _articleNavigationPage;
        private ArticlePage _articlePage;

        [SetUp]
        public void SetUp()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");

            _driver = new ChromeDriver(path, options);
            _microsoftDocsMainPage = new MicrosoftDocsMainPage(_driver);
            _treePage = new TreePage(_driver);
            _articleNavigationPage = new ArticleNavigationPage(_driver);
            _articlePage = new ArticlePage(_driver);
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
        public void Test()
        {
            _microsoftDocsMainPage.NavigateTo();
            _treePage.ClickOnDotNetCoreGuideLink();
            _treePage.ClickOnDockerLink();
            _treePage.ClickOnIntroductionDotNetDockerLink();
            string initalURL = _articlePage.GetFullUrl();
            string ancher = _articleNavigationPage.GetArticleAncker(2);

            _articleNavigationPage.ClickOnArticleLink(2);

            string brawserFullURL = _articlePage.GetFullUrl();
            string expectedURL = initalURL + ancher;
            Assert.AreEqual(expectedURL, brawserFullURL);
        }

        private void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}
