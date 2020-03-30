using ExamPreparation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QAAutomation_Exam_2.Pages.CostumizeIconsPage
{
    public partial class CostumizeIconsPage : BasePage
    {
        public CostumizeIconsPage(IWebDriver driver) : base(driver)
        {
        }

        public List<IWebElement> Sections => new List<IWebElement> {
                this.Section1,
                this.Section2,
                this.Section3,
                this.Section4
            };

        public void ClickToggleButton()
        {
            this.ToggleIconsButton.Click();
        }

        public void ClickOnSection(int sectionNumber)
        {
            Sections[sectionNumber - 1].Click();
        }

        public bool AreAllToggleIconsDisplayed()
        {
            bool displayed = false;

            foreach (var section in Sections)
            {
                displayed = IsSectionToggleIconPresent(section);
            }

            return displayed;
        }

        public bool IsCorrectSectionExpanded(int sectionIndex)
        {
            List<bool> sectionsExpandState = GenerateSectionExpandState(sectionIndex);
            bool isCorrect = true;

            for(int i=0; i< Sections.Count; i++)
            {
                if (IsSectionExpanded(Sections[i]) != sectionsExpandState[i])
                {
                    isCorrect = false;
                }
            }

            return isCorrect;
        }

        #region Helper Methods

        private List<bool> GenerateSectionExpandState(int sectionIndex)
        {
            List<bool> sectionsState = new List<bool>();

            for (int i = 0; i < Sections.Count; i++)
            {
                if (i == sectionIndex - 1)
                {
                    sectionsState.Add(true);
                }
                else
                {
                    sectionsState.Add(false);
                }
            }

            return sectionsState;
        }

        private bool IsSectionExpanded(IWebElement section)
        {
            if (section.GetAttribute("aria-expanded") == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }        

        private IWebElement GetSectionByIndex(int sectionIndex)
        {
            return Sections[sectionIndex - 1];
        }

        private bool IsSectionToggleIconPresent(IWebElement sectionElement)
        {
            string xpath = "//*[@id=\"" + sectionElement.GetAttribute("id") + "\"]/span";

            if (IsElementPresent(By.XPath(xpath)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                this.Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion
    }
}
