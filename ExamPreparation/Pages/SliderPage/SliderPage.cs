namespace QAAutomation_Exam_2.Pages.SliderPage
{
    using ExamPreparation.Pages;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class SliderPage : BasePage
    {
        public SliderPage(IWebDriver driver) : base(driver) 
        {
        }

        public void DragSliderRight()
        {
            Actions action = new Actions(this.Driver);
            //73.921 = 665.219 / 9
            action.DragAndDropToOffset(this.Slider, 74, 0);
            action.Perform();
            
        }

        public string GetSliderInputValue()
        {
            var value = this.SliderInput.GetAttribute("value");
            return value;
        }

        private double GetSliderMaxRange()
        {
            double maxRange;
            string maxRangeString = this.SliderTrack.GetAttribute("width");
            Double.TryParse(maxRangeString, out maxRange);

            return maxRange;
        }
    }
}
