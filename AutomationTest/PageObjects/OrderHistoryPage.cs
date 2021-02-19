using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class OrderHistoryPage
    {
        public OrderHistoryPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Order history page

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[1]")]
        public IWebElement orderRef { get; set; }

        

    }
}
