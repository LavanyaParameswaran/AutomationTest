using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace Com_Test_Lavanya
{
    [Binding]
    public class PerformOnScreen
    {

       private string strOrderNo;

       [Given(@"launch ""(.*)"" browser")]
        public void GivenLaunch(string strBrowserType)
        {
            SeleniumUtility.fnGetDriver(strBrowserType);            
        }
        
        [When(@"I navigate to ""(.*)"" website")]
        public void WhenEnterWebsite(string strURL)
        {
            SeleniumUtility.fnOpenUrl(strURL);
        }
           

        [Then(@"I verify ""(.*)"" page is displayed")]
        public void ThenIVerifyPageIsDisplayed(string strPage)
        {
            HomePage homePage = new HomePage();            
            switch (strPage)
            {                
                case "home":
                    SeleniumUtility.fnWaitForPageLoading();
                    break;
                case "my account":
                    Assert.AreEqual(SeleniumUtility.driver.Title, "My account - My Store");
                    break;
                case "T-shirts":
                    Assert.AreEqual(SeleniumUtility.driver.Title, "T-shirts - My Store");
                    break;
                case "Shopping summary":
                    Assert.AreEqual(SeleniumUtility.driver.Title, "Order - My Store");
                    break;
                case "ADDRESSES":
                    Assert.AreEqual(homePage.pageHeading.Text, "ADDRESSES");
                    break;
                case "SHIPPING":
                    Assert.IsTrue(homePage.pageHeading.Text.Contains("SHIPPING"));
                    break;
                case "Payment":
                    Assert.AreEqual(homePage.pageHeading.Text, "PLEASE CHOOSE YOUR PAYMENT METHOD");
                    break;
                case "Order Confirmation":
                    Assert.IsTrue(homePage.pageHeading.Text.Contains("ORDER CONFIRMATION"));
                    break;
                case "ORDER HISTORY":
                    Assert.IsTrue(homePage.pageHeading.Text.Contains("ORDER HISTORY"));
                    break;
                case "Personal Information":
                    Assert.AreEqual(SeleniumUtility.driver.Title, "Identity - My Store");
                    break;
                default:
                    break;


            }
        }      



        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            SeleniumUtility.fnCloseBrowser();

        }        

        [When(@"I click on SignIn button")]
        public void WhenIClickOnLink()
        {
            SeleniumUtility.fnClickOnSignInBtn();
        }

        [When(@"I login to the portal with the following details")]
        public void WhenILoginToThePortalWithTheFollowingDetails(Table table)
        {
            var details = table.CreateInstance<Details>();
            SeleniumUtility.fnEnterLoginDetails(UserCredentials.GetVariableValue(details.Email), UserCredentials.GetVariableValue(details.Password));
            SeleniumUtility.fnClickOnLoginBtn();
        }

        [When(@"I click on ""(.*)""")]
        public void ThenIClickOn(string strLink)
        {
            SeleniumUtility.fnClickOnLink(strLink);
        }

        [Then(@"I hover mouse and click Add to cart")]
        public void ThenIHoverMouseAndClickAddToCart()
        {
            SeleniumUtility.fnHoverMouse();
            SeleniumUtility.fnClickOnLink("Add to cart");
        }

        [Then(@"I verify product added successfully")]
        public void ThenIVerifyProductAddedSuccessfully()
        {
            SeleniumUtility.fnVerifyProductAdded();
        }

        [Then(@"I get order reference")]
        public void ThenIGetOrderReference()
        {
            strOrderNo = SeleniumUtility.fnGetOrderRef();
        }

        [Then(@"I verify order in order history")]
        public void ThenIVerifyOrderInOrderHistory()
        {
            Assert.IsTrue(strOrderNo.Contains(SeleniumUtility.fnGetOrderRefFromHistory()));
        }

        [When(@"I update first name to ""(.*)""")]
        public void WhenIUpdateFirstNameTo(string strFirstName)
        {
            SeleniumUtility.fnEnterText("First Name",strFirstName);
        }

        [Then(@"I enter password")]
        public void ThenIEnterPassword()
        {
            SeleniumUtility.fnEnterText("Password",UserCredentials.GetVariableValue("adminpwd"));
        }
        
        [Then(@"I verify personal information is successfully updated")]
        public void ThenIVerifyPersonalInformationIsSuccessfullyUpdated()
        {
            SeleniumUtility.fnVerifySuccessMsg();
        }

    }
}
