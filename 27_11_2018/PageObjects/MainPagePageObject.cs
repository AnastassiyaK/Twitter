using _27_11_2018.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_11_2018.PageObjects
{
    class MainPagePageObject
    {
        private const string newtweetField = "//div[contains(@*, 'Tweetstorm-tweet-box-0-label')]";
        public MainPagePageObject()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }
        //button to open modal window
        [FindsBy(How = How.Id, Using = "global - new- tweet - button")]
        private IWebElement btnTweet;
        //button to enter text
        [FindsBy(How = How.XPath, Using = newtweetField)]
        private IWebElement textTweet;



    }
}
