using DemoMobileAutomation.TestData.AndroidApps.mdLottery;
using OpenQA.Selenium;
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
   public class LandingPageFunctionalities
    {
       public static AppiumDriver<AndroidElement> driver;     
       KeyFunctions keygeneric = new KeyFunctions(driver);
       DesiredCapabilities capabilities = new DesiredCapabilities();
       LandingPageElements landingpageElement = new LandingPageElements();
       RegisterNowPageElements registerpageElement = new RegisterNowPageElements();

       public static void Main(string[] args)
       {
           LandingPageFunctionalities lp = new LandingPageFunctionalities();
           //lp.Execute();
           MemberFeedbackPageServices mf = new MemberFeedbackPageServices();
           mf.memberFeedback();

       }





        public void Execute()
        {
            keygeneric.mdLotteryCapabilities(capabilities);
            driver = new AndroidDriver<AndroidElement>(new Uri(ConfigurationManager.AppSettings["URL"]), capabilities);
            PageFactory.InitElements(driver, registerpageElement);
            PageFactory.InitElements(driver, landingpageElement);

            try
            {             
                Thread.Sleep(20000);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50000));
                wait.Until(ExpectedConditions.ElementToBeClickable(landingpageElement.registerLink));
                
                landingpageElement.registerLink.Click();
                Thread.Sleep(4000);

                wait.Until(ExpectedConditions.ElementToBeClickable(registerpageElement.EnterFN));
                registerpageElement.EnterFN.SendKeys("suparna"); driver.HideKeyboard();
                registerpageElement.EnterMN.Click(); registerpageElement.EnterMN.SendKeys("s"); driver.HideKeyboard();
                registerpageElement.EnterLN.Click(); registerpageElement.EnterLN.SendKeys("khamaru"); driver.HideKeyboard();
               

                registerpageElement.EnterAddressLine1.Click(); registerpageElement.EnterAddressLine1.SendKeys("itpl, bangalore, india");
                driver.HideKeyboard();

                int Height = driver.Manage().Window.Size.Height; //1776
                int Width = driver.Manage().Window.Size.Width;  //1080
                    int Starty = (int)(Height / 2);                   //886.5
                    int Endy = (int)(Height * 0.90);                 //1243
                    int Startx = (int)(Width / 2);                   // 540

                driver.Swipe(Startx, Endy, Startx, Starty, 1000); //top to bottom
                // driver.Swipe(Startx, Starty, Startx, Endy, 1000); //bottom to top 
                driver.Swipe(Startx, Endy, Startx, Starty, 1000);

                registerpageElement.EnterZipCode.Click();
                registerpageElement.EnterZipCode.SendKeys("56006"); driver.HideKeyboard();
                driver.Swipe(Startx, Endy, Startx, Starty, 1000);
                registerpageElement.EnterPreferredContact.Click();
                //driver.Swipe(Startx, Endy, Startx, Starty, 1000);


                registerpageElement.EnterPreferredContact.SendKeys("8888888888");
                registerpageElement.EnterMobileNumber.Click();
                //driver.Swipe(Startx, Endy, Startx, Starty, 1000);

                registerpageElement.EnterMobileNumber.SendKeys("9876543210");
                driver.HideKeyboard();

                registerpageElement.EnterDOB_Month.Click();
                driver.FindElementByName("May").Click();

                registerpageElement.EnterDOB_Day.Click();
                driver.Swipe(Startx, Endy, Startx, Starty, 1000);  driver.Swipe(Startx, Endy, Startx, Starty, 1000);
                driver.FindElementByName("10").Click(); 

                registerpageElement.EnterDOB_Year.Click();
                driver.Swipe(Startx, Endy, Startx, Starty, 1000);
                driver.FindElementByName("1990").Click();

                registerpageElement.CertifyCheckbox.Click();
                registerpageElement.EnterGender.Click();

                int Endy1 = (int)(Height / 2);          //888       
                int Startx1 = (int)(Width * 0.30);        //108
                int Endx1 = (int)(Width * 0.90);          //972
                //driver.Swipe(Startx1, Endy1, Endx1, Endy1, 200); //left to right swipe
                

                driver.Swipe(Startx, Starty, Startx, Endy, 1000);
                driver.Swipe(Startx, Starty, Startx, Endy, 1000);
                driver.Swipe(Startx, Starty, Startx, Endy, 1000);
                driver.Swipe(Startx, Starty, Startx, Endy, 1000);

                driver.FindElementByXPath("//android.view.View[@content-desc='Maryland Lottery']").Zoom();
                Thread.Sleep(1000);
                driver.FindElementByXPath("//android.view.View[@content-desc='Maryland Lottery']").Pinch();
                Thread.Sleep(5000);

            }
            catch
            {
                driver.GetScreenshot().SaveAsFile("C:\\Users\\104919\\Videos\\screenshots\\mslottery.Jpeg", ScreenshotImageFormat.Jpeg);

            }
        }
    }
}

