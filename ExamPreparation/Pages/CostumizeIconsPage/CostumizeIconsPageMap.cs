namespace QAAutomation_Exam_2.Pages.CostumizeIconsPage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class CostumizeIconsPage
    {
        public IWebElement ToggleIconsButton => this.Wait.Until(d => d.FindElement(By.Id("toggle")));

        public IWebElement Section1 => this.Wait.Until(d => d.FindElement(By.Id("ui-id-12")));

        public IWebElement Section2 => this.Wait.Until(d => d.FindElement(By.Id("ui-id-14")));

        public IWebElement Section3 => this.Wait.Until(d => d.FindElement(By.Id("ui-id-16")));

        public IWebElement Section4 => this.Wait.Until(d => d.FindElement(By.Id("ui-id-18")));

        public IWebElement Section1Content => this.Wait.Until(d => d.FindElement(By.Id("ui-id-13")));

        public IWebElement Section2Content => this.Wait.Until(d => d.FindElement(By.Id("ui-id-15")));

        public IWebElement Section3Content => this.Wait.Until(d => d.FindElement(By.Id("ui-id-17")));

        public IWebElement Section4Content => this.Wait.Until(d => d.FindElement(By.Id("ui-id-19")));

        public List<IWebElement> Icons => this.Wait.Until(d => d.FindElements(By.ClassName("ui-accordion-header-icon")).ToList());

    }
}
