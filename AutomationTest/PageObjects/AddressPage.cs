using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class AddressPage
    {
        public AddressPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Address page

        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement lnkCheckout { get; set; }

    }
}
