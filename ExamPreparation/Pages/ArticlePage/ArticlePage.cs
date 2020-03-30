namespace QAAutomation_Exam_2.Pages.ArticlePage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver) : base(driver)
        {
        }

        public string GetFullUrl()
        {
            return this.Driver.Url;
        }
    }
}
