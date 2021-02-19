using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class HomePage
    {
        public HomePage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Home page

        [FindsBy(How = How.Id, Using = "header_logo")]
        public IWebElement statictxtAutomationTest { get; set; }

        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement pageHeading { get; set; }

    }
}
