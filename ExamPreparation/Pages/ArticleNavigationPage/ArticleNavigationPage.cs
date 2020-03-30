namespace QAAutomation_Exam_2.Pages.ArticleNavigationPage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class ArticleNavigationPage : BasePage
    {
        public ArticleNavigationPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnArticleLink(int index)
        {
            Links[index-1].Click();
        }

        public bool IsLinkSelected(int index)
        {
            return Links[index - 1].GetAttribute("class") == "selected";
        }

        public string GetArticleAncker(int index)
        {
            var link = GetLink(Links[index - 1]);
            var value = link.GetAttribute("href");
            return value;
        }

        private IWebElement GetLink(IWebElement element)
        {
            return element.FindElement(By.XPath("//a"));
        }

        public void MoveToArticle()
        {
            var element = this.Wait.Until(d => d.FindElement(By.Id("next-steps")));
            //Actions action = new Actions(this.Driver);
            //action.MoveByOffset(0, 500);
            //action.Perform();

            IJavaScriptExecutor je = (IJavaScriptExecutor)this.Driver;
            je.ExecuteScript("arguments[0].scrollIntoView(false);", element);
        }
    }
}
