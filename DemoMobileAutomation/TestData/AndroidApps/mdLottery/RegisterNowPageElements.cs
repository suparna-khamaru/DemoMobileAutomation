using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMobileAutomation.TestData.AndroidApps.mdLottery
{
    public class RegisterNowPageElements
    {
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Legal First Name:']")] [CacheLookup] public IWebElement EnterFN;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Middle Initial:']")] [CacheLookup] public IWebElement EnterMN;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Legal Last Name:']")] [CacheLookup] public IWebElement EnterLN;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Address:']")] [CacheLookup] public IWebElement EnterAddressLine1;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='ZIP Code:']")] [CacheLookup] public IWebElement EnterZipCode;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Preferred Contact #:']")] [CacheLookup] public IWebElement EnterPreferredContact;
        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@content-desc='Mobile #:']")] [CacheLookup] public IWebElement EnterMobileNumber;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Month']")] [CacheLookup] public IWebElement EnterDOB_Month;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Day']")] [CacheLookup] public IWebElement EnterDOB_Day;
        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@content-desc='Year']")] [CacheLookup] public IWebElement EnterDOB_Year;
        [FindsBy(How = How.XPath, Using = "//android.widget.CheckBox[@content-desc='I certify that I am 18 years of age or older.']")] [CacheLookup] public IWebElement CertifyCheckbox;
        [FindsBy(How = How.XPath, Using = "//android.widget.RadioButton[@content-desc='Female']")] [CacheLookup] public IWebElement EnterGender;


    }
}
