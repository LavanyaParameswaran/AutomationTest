using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace Com_Test_Lavanya
{
    public static class SeleniumUtility
    {
        public static IWebDriver driver;
        public static IWebElement elem;

        public static void fnGetDriver(string strBrowserType)
        {
            //Launching the browser
            if (strBrowserType.ToLower() == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                driver = new ChromeDriver(options);
            }
            //Implicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

        }

        public static void fnOpenUrl(string strURL)
        {
            //Navigate to the URL
            if (strURL.ToLower() == "automation test")
                driver.Navigate().GoToUrl(UserCredentials.GetVariableValue("url"));
            else
                driver.Navigate().GoToUrl(strURL);
        }

        public static void fnCloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        public static void fnWaitForPageLoading()
        {

            try
            {
                //Wait for element to be visible
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("header_logo")));
            }
            catch
            {
                elem = null;
            }


        }

        public static void fnWaitForElement(IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(45));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

               
        public static void fnClickOnSignInBtn()
        {
            try
            {
                fnWaitForPageLoading();
                SignInPage signin = new SignInPage();
                fnWaitForElement(signin.btnSignIn);
                signin.btnSignIn.Click();
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnClickOnLink(string strLink)
        {
            try
            {
                fnWaitForPageLoading();
                TshirtsPage shirtsPage = new TshirtsPage();
                ShoppingCart cartPage = new ShoppingCart();
                AddressPage addressPage = new AddressPage();
                ShippingPage shippingPage = new ShippingPage();
                PaymentPage paymentPage = new PaymentPage();
                OrderConfirmationPage orderConfirmationPage = new OrderConfirmationPage();
                PersonalInfoPage personalInfo = new PersonalInfoPage();
                MyAcctPage myAcctPage = new MyAcctPage();
                if (strLink.ToLower().Contains("shirts"))
                {                    
                    fnWaitForElement(shirtsPage.lnkTShirt);
                    shirtsPage.lnkTShirt.Click();
                }
                else if (strLink.ToLower().Contains("cart"))
                {                    
                    fnWaitForElement(shirtsPage.lnkAddToCart);
                    shirtsPage.lnkAddToCart.Click();
                }
                else if (strLink.ToLower().Contains("proceed"))
                {
                    fnWaitForElement(shirtsPage.lnkCheckout);
                    shirtsPage.lnkCheckout.Click();
                }
                else if (strLink.ToLower().Contains("standard"))
                {
                    fnWaitForElement(cartPage.lnkStandardCheckout);
                    cartPage.lnkStandardCheckout.Click();
                }
                else if (strLink.ToLower().Contains("address"))
                {
                    fnWaitForElement(addressPage.lnkCheckout);
                    addressPage.lnkCheckout.Click();
                }
                else if (strLink.ToLower().Contains("agree terms"))
                {
                    fnWaitForElement(shippingPage.lnkAgreeTerms);
                    shippingPage.lnkAgreeTerms.Click();
                }
                else if (strLink.ToLower().Contains("shipping"))
                {
                    fnWaitForElement(shippingPage.lnkProceedShipping);
                    shippingPage.lnkProceedShipping.Click();
                }
                else if (strLink.ToLower().Contains("bank wire"))
                {
                    fnWaitForElement(paymentPage.lnkBankWire);
                    paymentPage.lnkBankWire.Click();
                }
                else if (strLink.ToLower().Contains("confirm order"))
                {
                    fnWaitForElement(paymentPage.lnkConfirmOrder);
                    paymentPage.lnkConfirmOrder.Click();
                }
                else if (strLink.ToLower().Contains("back to orders"))
                {
                    fnWaitForElement(orderConfirmationPage.lnkBckToOrders);
                    orderConfirmationPage.lnkBckToOrders.Click();
                }
                else if (strLink.ToLower().Contains("personal information"))
                {
                    fnWaitForElement(myAcctPage.lnkPersonalInfo);
                    myAcctPage.lnkPersonalInfo.Click();
                }
                else if (strLink.ToLower().Contains("save"))
                {
                    fnWaitForElement(personalInfo.btnSave);
                    personalInfo.btnSave.Click();
                }

            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnClickOnLoginBtn()
        {
            try
            {
                fnWaitForPageLoading();
                SignInPage signin = new SignInPage();
                fnWaitForElement(signin.btnLogin);
                signin.btnLogin.Click();
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnEnterLoginDetails(string strEmail, string strPwd)
        {
            try
            {
                //Wait for Element
                fnWaitForPageLoading();
                SignInPage signin = new SignInPage();
                fnWaitForElement(signin.txtEmail);
                //Enter Email
                signin.txtEmail.Clear();
                signin.txtEmail.SendKeys(strEmail);
                fnWaitForElement(signin.txtPassword);
                //Enter Password
                signin.txtPassword.Clear();
                signin.txtPassword.SendKeys(strPwd);
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnHoverMouse()
        {
            try
            {
                fnWaitForPageLoading();
                TshirtsPage shirtsPage = new TshirtsPage();
                fnWaitForElement(shirtsPage.ProductView);
                Actions action = new Actions(driver);
                action.MoveToElement(shirtsPage.ProductView).Perform();
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnVerifyProductAdded()
        {
            try
            {
                fnWaitForPageLoading();
                TshirtsPage shirtsPage = new TshirtsPage();
                fnWaitForElement(shirtsPage.ProductAdded);
                Assert.IsNotNull(shirtsPage.ProductAdded);                
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static void fnEnterText(string strText,string strValue)
        {
            try
            {
                fnWaitForPageLoading();
                PersonalInfoPage personalInfoPage = new PersonalInfoPage();
                if (strText == "First Name")
                {
                    fnWaitForElement(personalInfoPage.txtFN);
                    elem = personalInfoPage.txtFN;
                }
                else if (strText == "Password")
                {
                    fnWaitForElement(personalInfoPage.txtPwd);
                    elem = personalInfoPage.txtPwd;
                }
                elem.Clear();
                elem.SendKeys(strValue);
            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }

        public static string fnGetOrderRef()
        {
            string strOrderNo = "";
            try
            {
                fnWaitForPageLoading();
                OrderConfirmationPage orderConfirmPage = new OrderConfirmationPage();
                fnWaitForElement(orderConfirmPage.orderRef);
                Assert.IsNotNull(orderConfirmPage.orderRef.Text);
                strOrderNo = orderConfirmPage.orderRef.Text;

            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
            return strOrderNo;

        }

        public static string fnGetOrderRefFromHistory()
        {
            string strOrderNo = "";
            try
            {
                fnWaitForPageLoading();
                OrderHistoryPage orderHistoryPage = new OrderHistoryPage();
                fnWaitForElement(orderHistoryPage.orderRef);
                Assert.IsNotNull(orderHistoryPage.orderRef.Text);
                strOrderNo = orderHistoryPage.orderRef.Text;

            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
            return strOrderNo;

        }

        public static void fnVerifySuccessMsg()
        {
            try
            {
                fnWaitForPageLoading();
                PersonalInfoPage personalInfo = new PersonalInfoPage();
                fnWaitForElement(personalInfo.statictxtSucccess);
                Assert.IsTrue(personalInfo.statictxtSucccess.Text.ToLower().Contains("success"));

            }
            catch (Exception e)
            {
                fnCloseBrowser();
                throw new SystemException("Unable to find Element " + e.Message);
            }
        }
    }
}