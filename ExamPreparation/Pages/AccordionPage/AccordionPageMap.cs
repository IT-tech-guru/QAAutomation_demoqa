namespace QAAutomation_Exam_2.Pages.AccordionPage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class AccordionPage
    {
        public IWebElement CostumizeIconsTab => this.Wait.Until(d => d.FindElement(By.Id("ui-id-2")));
    }
}
