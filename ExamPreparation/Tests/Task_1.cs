namespace QAAutomation_Exam_2.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using QAAutomation_Exam_2.Pages.MainPage;
    using QAAutomation_Exam_2.Pages.SliderPage;
    using System;
    using System.IO;
    using System.Reflection;
    
    [TestFixture]
    public class Task_1
    {
        private IWebDriver _driver;
        private MainPage _mainPage;
        private SliderPage _sliderPage;

        [SetUp]
        public void SetUp()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");

            _driver = new ChromeDriver(path, options);
            _mainPage = new MainPage(_driver);
            _sliderPage = new SliderPage(_driver);
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
        public void SliderMoveRightTest()
        {
            _mainPage.NavigateTo();
            _mainPage.GoToSliderPage();

            for (int i = 1; i < 9; i++)
            {
                _sliderPage.DragSliderRight();
                string sliderInputValue = _sliderPage.GetSliderInputValue();
                string expectedValue = (i + 2).ToString();

                Assert.AreEqual(expectedValue, sliderInputValue);
            }
        }

        private void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            screenshot.SaveAsFile(saveLocation, ScreenshotImageFormat.Png);
        }
    }
}
