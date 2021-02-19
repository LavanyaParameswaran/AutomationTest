using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class PaymentPage
    {
        public PaymentPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Payment page        

        [FindsBy(How = How.ClassName, Using = "bankwire")]
        public IWebElement lnkBankWire { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'button btn btn-default button-medium')]")]
        public IWebElement lnkConfirmOrder { get; set; }

    }
}
