namespace QAAutomation_Exam_2.Pages.MicrosoftDocsMainPage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class MicrosoftDocsMainPage : BasePage
    {
        public MicrosoftDocsMainPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/dotnet/csharp/ ");
        }
    }
}
