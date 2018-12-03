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
        public MainPagePageObject()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "global - new- tweet - button"]
        private IWebElement btnTweet;
        [FindsBy(How = How.Id, Using = "global - new- tweet - button"]
        private IWebElement btnTweet;
    }
}
