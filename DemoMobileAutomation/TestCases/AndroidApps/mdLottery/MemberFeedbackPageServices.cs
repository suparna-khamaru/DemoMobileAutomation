using DemoMobileAutomation.TestData.AndroidApps.mdLottery;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMobileAutomation.TestCases.AndroidApps.mdLottery
{
    public class MemberFeedbackPageServices
    {
         MemberFeedbackPageElements memberFeedbackPageElements = new MemberFeedbackPageElements();
         public static AppiumDriver<AndroidElement> driver; 
         DesiredCapabilities capabilities = new DesiredCapabilities();
         KeyFunctions keygeneric = new KeyFunctions(driver);
         LandingPageElements landingpageElements = new LandingPageElements();
         
        public void memberFeedback()
        {
            keygeneric.mdLotteryCapabilities(capabilities);
            driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
            PageFactory.InitElements(driver, memberFeedbackPageElements);
            enterValidDetailsinMemberFeedbackScreen();  
        }

        public void goToMemberFeedbackScreen()
        {
            PageFactory.InitElements(driver, landingpageElements);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50000));
            wait.Until(ExpectedConditions.ElementToBeClickable(landingpageElements.MenuButton));
            landingpageElements.MenuButton.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(landingpageElements.MemberFeedbackInMenuBar));
            landingpageElements.MemberFeedbackInMenuBar.Click();  
            wait.Until(ExpectedConditions.ElementToBeClickable(memberFeedbackPageElements.EnterFN));
        }


        public void enterValidDetailsinMemberFeedbackScreen()
        {
            goToMemberFeedbackScreen();
            memberFeedbackPageElements.EnterFN.Click();
            memberFeedbackPageElements.EnterFN.SendKeys("First Name"); //driver.HideKeyboard();
            verticalSwipeDown();
            memberFeedbackPageElements.EnterLN.Click();
            memberFeedbackPageElements.EnterLN.SendKeys("Last Name"); //driver.HideKeyboard();
            memberFeedbackPageElements.EnterEmail.Click();
            memberFeedbackPageElements.EnterEmail.SendKeys("demo.scen@gmail.com"); //driver.HideKeyboard();
            enterDOB();
            memberFeedbackPageElements.EnterEmail.Click(); //driver.HideKeyboard();
            verticalSwipeDown();
            memberFeedbackPageElements.EnterZipCode.Click();
            memberFeedbackPageElements.EnterZipCode.SendKeys("56000");
            memberFeedbackPageElements.EnterPhoneNumber.Click();
            memberFeedbackPageElements.EnterPhoneNumber.SendKeys("9876543210");
            memberFeedbackPageElements.ChooseInternetConnection.Click();
            driver.FindElementByName("DSL").Click();
            memberFeedbackPageElements.ChooseNatureOfIssue.Click();
            driver.FindElementByName("Security Issues").Click();
            memberFeedbackPageElements.ChooseSpecificNatureOfIssue.Click();
            driver.FindElementByName("Report a Security Issue").Click();
            verticalSwipeDown();
            memberFeedbackPageElements.EnterDescription.Click();
            memberFeedbackPageElements.EnterDescription.SendKeys("Hello i am the description!"); driver.HideKeyboard();
            memberFeedbackPageElements.ClickSubmitButton.Click();

        }

        public void enterDOB()
        {
            memberFeedbackPageElements.EnterDOB_Month.Click();
            driver.FindElementByName("Jun").Click();
            memberFeedbackPageElements.EnterDOB_Day.Click();
            driver.FindElementByName("7").Click();
            memberFeedbackPageElements.EnterDOB_Year.Click();
            driver.FindElementByName("1996").Click();
        }


        public void verticalSwipeDown()
        {
                int Height = driver.Manage().Window.Size.Height; //1776
                int Width = driver.Manage().Window.Size.Width;  //1080
                int Starty = (int)(Height / 2);                   //886.5
                int Endy = (int)(Height * 0.90);                 //1243
                int Startx = (int)(Width / 2);                   // 540
            driver.Swipe(Startx, Endy, Startx, Starty, 1000); //top to bottom   
        }

        public void verticalSwipeUp()
        {
                int Height = driver.Manage().Window.Size.Height; //1776
                int Width = driver.Manage().Window.Size.Width;  //1080
                int Starty = (int)(Height / 2);                   //886.5
                int Endy = (int)(Height * 0.90);                 //1243
                int Startx = (int)(Width / 2);                   // 540
            driver.Swipe(Startx, Starty, Startx, Endy, 1000); //bottom to top 
        }

        public void horizontalSwipe()
        {
                int Height = driver.Manage().Window.Size.Height; //1776
                int Width = driver.Manage().Window.Size.Width;  //1080
                int Endy1 = (int)(Height / 2);          //888       
                int Startx1 = (int)(Width * 0.30);        //108
                int Endx1 = (int)(Width * 0.90);          //972
            driver.Swipe(Startx1, Endy1, Endx1, Endy1, 200); //left to right swipe
        }




    }
}
