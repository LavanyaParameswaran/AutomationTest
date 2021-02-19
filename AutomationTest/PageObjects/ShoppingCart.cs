using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Shopping Cart page

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'standard-checkout')]")]
        public IWebElement lnkStandardCheckout { get; set; }

    }
}
