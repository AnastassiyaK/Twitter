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
        private const string sendButton = "//div[@id='Tweetstorm-tweet-box-0']/descendant::button[contains(@class,'SendTweetsButton')]";
        private const string newpictureInput = "//div[contains(@id,'Tweetstorm-tweet-box-0')]/descendant::input[@class='file-input js-tooltip']";
        public MainPagePageObject()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }
        //button to open modal window
        [FindsBy(How = How.Id, Using = "global - new- tweet - button")]
        private IWebElement tweetButton;
        //button to enter text
        [FindsBy(How = How.XPath, Using = newtweetField)]
        private IWebElement textTweet;
        //button to send tweet
        [FindsBy(How = How.XPath, Using = sendButton)]
        private IWebElement sendtweetButton;
        //input to send a pic
        [FindsBy(How = How.XPath, Using = newpictureInput)]
        private IWebElement sendpicInput;

        public void PostPic(string path)
        {
            sendpicInput.SendKeys(path);
        }

        public void btnTweetClick()
        {
            tweetButton.Click();
        }

        public void EnterText(string text)
        {
            textTweet.SendKeys(text);
        }

        public void SendTweet()
        {
            sendtweetButton.Click();
        }

    }
}
