namespace QAAutomation_Exam_2.Pages.AccordionPage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class AccordionPage : BasePage
    {
        public AccordionPage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToCustomizeIconsPage()
        {
            this.CostumizeIconsTab.Click();
        }
    }
}
