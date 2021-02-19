using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class OrderConfirmationPage
    {
        public OrderConfirmationPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Order Confirm page

        [FindsBy(How = How.XPath, Using = "//*[@class='box']")]
        public IWebElement orderRef { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'button-exclusive btn')]")]
        public IWebElement lnkBckToOrders { get; set; }

    }
}
