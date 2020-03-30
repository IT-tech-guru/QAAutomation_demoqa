namespace QAAutomation_Exam_2.Pages.MainPage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/");
        }

        public void GoToSliderPage()
        {
            this.SliderSection.Click();
        }

        public void GoToAccordionPage()
        {
            this.AccordionSection.Click();
        }
    }
}
