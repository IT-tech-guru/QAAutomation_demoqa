namespace QAAutomation_Exam_2.Pages.TreePage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class TreePage : BasePage
    {
        public TreePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnDotNetCoreGuideLink()
        {
            this.DotNetCoreGuideLink.Click();
        }

        public void ClickOnDockerLink()
        {
            this.DockerLink.Click();
        }

        public void ClickOnIntroductionDotNetDockerLink()
        {
            this.IntroductionDotNetDockerLink.Click();
        }
    }
}
