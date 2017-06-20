using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMobileAutomation.TestData.AndroidApps.mdLottery
{
    public class LandingPageElements
    {
        [FindsBy(How = How.XPath, Using = "//android.view.View[@content-desc='REGISTER NOW']")] 
        [CacheLookup] 
        public IWebElement registerLink;

        [FindsBy(How = How.Id, Using = "com.mdi.mdlottery:id/reveal_icon")]
        [CacheLookup]
        public IWebElement MenuButton;

        [FindsBy(How = How.XPath, Using = "//android.widget.TextView[@text='Member Feedback']")]
        [CacheLookup]
        public IWebElement MemberFeedbackInMenuBar;
    }
}
