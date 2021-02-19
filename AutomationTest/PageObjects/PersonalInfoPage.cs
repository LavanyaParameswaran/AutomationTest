using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class PersonalInfoPage
    {
        public PersonalInfoPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Personal Info page

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement txtFN { get; set; }

        [FindsBy(How = How.Id, Using = "old_passwd")]
        public IWebElement txtPwd { get; set; }

        [FindsBy(How = How.Name, Using = "submitIdentity")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'alert-success')]")]
        public IWebElement statictxtSucccess { get; set; }

    }
}
