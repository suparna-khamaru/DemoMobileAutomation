using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMobileAutomation.TestData.AndroidApps.mdLottery
{
    public class MemberFeedbackPageElements
    {

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='First Name:']")] [CacheLookup] public IWebElement EnterFN;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Last Name:']")] [CacheLookup] public IWebElement EnterLN;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Email Address:']")] [CacheLookup] public IWebElement EnterEmail;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Month']")] [CacheLookup] public IWebElement EnterDOB_Month;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Day']")] [CacheLookup] public IWebElement EnterDOB_Day;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Year']")] [CacheLookup] public IWebElement EnterDOB_Year;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Zip Code:']")] [CacheLookup] public IWebElement EnterZipCode;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Phone Number:']")] [CacheLookup] public IWebElement EnterPhoneNumber;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Choose One' and @index='15']")] [CacheLookup] public IWebElement ChooseInternetConnection;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Choose One' and @index='1']")] [CacheLookup] public IWebElement ChooseNatureOfIssue;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Choose One' and @index='2']")] [CacheLookup] public IWebElement ChooseSpecificNatureOfIssue;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Description of Issue. Please be as specific as possible.']")] [CacheLookup] public IWebElement EnterDescription;
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@content-desc='Submit']")] [CacheLookup] public IWebElement ClickSubmitButton;
    }
}
