using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class ShippingPage
    {
        public ShippingPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Shipping page

        [FindsBy(How = How.Id, Using = "uniform-cgv")]
        public IWebElement lnkAgreeTerms { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement lnkProceedShipping { get; set; }

    }
}
