namespace QAAutomation_Exam_2.Pages.ArticleNavigationPage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class ArticleNavigationPage
    {
        public IWebElement SideDocOutline => this.Wait.Until(d => d.FindElement(By.Id("side-doc-outline")));

        public List<IWebElement> Links => this.SideDocOutline.FindElements(By.TagName("li")).ToList();

        public IWebElement SelectedLink => this.SideDocOutline.FindElement(By.ClassName("selected"));
    }
}
