using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class MyAcctPage
    {
        public MyAcctPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the My Acct page

        [FindsBy(How = How.LinkText, Using = "My account")]
        public IWebElement statictxtMyAcct { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='My personal information']")]
        public IWebElement lnkPersonalInfo { get; set; }

    }
}
