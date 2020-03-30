namespace QAAutomation_Exam_2.Pages.SliderPage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class SliderPage
    {
        public IWebElement Slider => this.Wait.Until(d => d.FindElement(By.ClassName("ui-slider-handle")));

        public IWebElement SliderInput => this.Wait.Until(d => d.FindElement(By.Id("amount1")));

        public IWebElement SliderTrack => this.Wait.Until(d => d.FindElement(By.Id("slider-range-max")));
    }
}
