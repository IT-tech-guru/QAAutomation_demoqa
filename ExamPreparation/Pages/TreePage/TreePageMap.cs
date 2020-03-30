namespace QAAutomation_Exam_2.Pages.TreePage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class TreePage
    {
        public IWebElement DotNetCoreGuideLink => this.Wait.Until(d => d.FindElement(By.LinkText(".NET Core Guide")));

        public IWebElement DockerLink => this.Wait.Until(d => d.FindElement(By.LinkText("Docker")));

        public IWebElement IntroductionDotNetDockerLink => this.Wait.Until(d => d.FindElement(By.LinkText("Introduction to .NET and Docker")));
    }
}
