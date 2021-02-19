using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com_Test_Lavanya
{
    public class SignInPage
    {
        public SignInPage()
        {
           PageFactory.InitElements(SeleniumUtility.driver, this);
        }

        //To get the objects on the Home page

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword { get; set; }


    }
}
