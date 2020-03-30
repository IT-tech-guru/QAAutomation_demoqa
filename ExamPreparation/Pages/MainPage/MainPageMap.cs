namespace QAAutomation_Exam_2.Pages.MainPage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class MainPage
    {
        public IWebElement SliderSection => this.Wait.Until(d => d.FindElement(By.LinkText("Slider")));

        public IWebElement AccordionSection => this.Wait.Until(d => d.FindElement(By.LinkText("Accordion")));
    }
}
