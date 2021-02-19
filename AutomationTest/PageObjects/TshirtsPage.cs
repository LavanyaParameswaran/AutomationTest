using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class TshirtsPage
    {
        public TshirtsPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the T-Shirts page

        [FindsBy(How = How.XPath, Using = "//*[@id='block_top_menu']/ul/li[3]/a[text()='T-shirts']")]
        public IWebElement lnkTShirt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/ul/li/div")]
        public IWebElement ProductView { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'add_to_cart_button')]")]
        public IWebElement lnkAddToCart { get; set; }

        [FindsBy(How = How.ClassName, Using = "clearfix")]
        public IWebElement ProductAdded { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to checkout']")]
        public IWebElement lnkCheckout { get; set; }





    }
}
