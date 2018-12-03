using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using _27_11_2018.Factory;
using _27_11_2018.PageObjects;

namespace _27_11_2018
{

    public class TweetClass
    {
       // public static IWebDriver Browser;
        //public TweetClass()
        //{
        //    Browser = new ChromeDriver();
        //}

        [SetUp]
        public void StartUpUrl()
        {
            DriverFactory.InitBrowser("Chrome");
           
        }
        

        public void LogIn()
        {
            MainPagePageObject loginpage = new MainPagePageObject();
            string login = "testtwe65442526";
            string password = "selenium";
            loginpage.LogIn(login,password);            
        }

        [Test]
        [Order(1)]
        public void AddTweet()
        {
            LogIn();
            //проверять на присутствие всплывающих окон
           // IWebElement Tweet = Browser.FindElement(By.Id("global-new-tweet-button"));
           // Tweet.Click();
           // IWebElement Field = Browser.FindElement(By.XPath("//*[@id='Tweetstorm-tweet-box-0']/div[2]/div[1]/div[2]/div[2]/div[2]/div[1]"));
           // string tweet = $"tweet {DateTime.Now}";
           // Field.SendKeys(tweet);
           // IWebElement Button = Browser.FindElement(By.XPath("//*[@id='Tweetstorm-tweet-box-0']/div[2]/div[2]/div[2]/span/button[2]"));
           // Button.Click();
           // Thread.Sleep(500);
           // List<IWebElement> Elements = Browser.FindElements(By.CssSelector("#stream-items-id b")).ToList();
           //// WebDriverWait wait2 = new WebDriverWait(Browser,TimeSpan.FromSeconds(5));
           // Browser.Navigate().Refresh();
           // Thread.Sleep(2000);
           // WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(5));
           // wait.Until(Browser => Browser.FindElement(By.XPath(null)));
           // //wait.Until(); ne null, ne false ,ajax, page load strategy, actions
           // //IJSExecutor
           // //(Browser, TimeSpan.FromSeconds(5));
           // List<IWebElement> NewElements = Browser.FindElements(By.CssSelector("#stream-items-id b")).ToList();
           // List<IWebElement> NewElementsText = Browser.FindElements(By.CssSelector("#stream-items-id p")).ToList();
           // Assert.That(Elements.Count, Is.EqualTo(NewElements.Count - 1));
           // Assert.That(NewElementsText[0].Text, Is.EqualTo(tweet));
            //добавлять проверки, чтобы отработали все
            //XPath("//*[@id="global-new-tweet-button"]");
        }

        //public static void WaitForElementLoad(By by, int timeoutInSeconds)
        //{
        //    if (timeoutInSeconds > 0)
        //    {
        //        WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(timeoutInSeconds));
        //        wait.Until(ExpectedConditions.ElementIsVisible(by));
        //    }
        //}

        [TearDown]
        public void CloseBrowser()
        {
            DriverFactory.CloseAllDrivers();
        }
        
        
        
    }
}
