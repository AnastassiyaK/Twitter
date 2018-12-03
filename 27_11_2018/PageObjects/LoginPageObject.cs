using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _27_11_2018.Factory;

namespace _27_11_2018.PageObjects
{
    class LoginPageObject
    {
        //private IWebDriver driver;
        private const string Url = "https://twitter.com/login";
        private const string LoginInput = "//input[@class='js-username-field email-input js-initial-focus']";
        private const string PasswordInput = "//input[@class='js-password-field']";
        private const string ButtonLogIn = "//button[contains(@class,'submit')]";

        [FindsBy(How = How.XPath,Using = LoginInput)]
        private IWebElement inputLogin { get; set; }

        [FindsBy(How = How.XPath, Using = PasswordInput)]
        private IWebElement inputPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ButtonLogIn)]
        private IWebElement btnLogIn { get; set; }

        public LoginPageObject()
        {
            //this.driver = driver;
            PageFactory.InitElements(DriverFactory.Driver,this);
        }

        public MainPagePageObject LogIn(string username, string password)
        {
            inputLogin.SendKeys(username);
            inputPassword.SendKeys(password);
            btnLogIn.Click();
            return new MainPagePageObject();
        }
        public void GoToPage()
        {
            DriverFactory.Driver.Navigate().GoToUrl(Url);
        }

       

    }
}
