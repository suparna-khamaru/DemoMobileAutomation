using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using Appium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DemoMobileAutomation
{

    public class Program
    {
        public static AppiumDriver<AndroidElement> driver;
        public static DesiredCapabilities capabilities = new DesiredCapabilities();

        public void AZLottery()
        {


            // cap.SetCapability("deviceName", "emulator-5554");
            // cap.SetCapability("platformName", "Android");
            // cap.SetCapability("platformVersion", "23");
            //// cap.SetCapability("BrowserName", "Android");
            // cap.SetCapability("AppActivity", "com.mdi.azlottery.mainActivity");
            // cap.SetCapability("AppPackage", "com.mdi.azlottery");
            // cap.SetCapability("app", "D:\\downloads-sw\\apk-apps\\AZApp-5.1.1.apk");
            // //cap.SetCapability("", "");
            // driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4725/wd/hub"), cap);

            capabilities.SetCapability("deviceName", "emulator-5554");
            capabilities.SetCapability(CapabilityType.Version, "6.0");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            capabilities.SetCapability("appPackage", "com.mdi.azlottery");
            capabilities.SetCapability("appActivity", "com.mdi.azlottery.MainActivity");
            capabilities.SetCapability("app", "D:\\downloads-sw\\apk-apps\\AZApp-5.1.1.apk");
            //capabilities.SetCapability("appPackage", "com.android.calculator2");
            //capabilities.SetCapability("appActivity", "com.android.calculator2.Calculator");

            capabilities.SetCapability("NEW_COMMAND_TIMEOUT", "10000");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);      //for android

            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10000));
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElementById("com.mdi.azlottery:id/reveal_icon")));

            string appHeadingText = driver.FindElementById("com.mdi.azlottery:id/title_text").Text;
            Console.WriteLine("app's landing screen's Heading Text: " + appHeadingText);

            AppiumWebElement MenuButton = driver.FindElementById("com.mdi.azlottery:id/reveal_icon");
            MenuButton.Click();                                                 //hamburger button
            driver.FindElementByName("Enter Tickets").Click();                  //Enter Tickets in menu 
            MenuButton.Click();                                                 //hamburger button
            driver.FindElementByName("Drawings and Winners").Click();           //Drawings and Winners in menu

        }
        public void calculator()
        {
            capabilities.SetCapability("deviceName", "emulator-5554");
            capabilities.SetCapability(CapabilityType.Version, "6.0");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            //capabilities.SetCapability("appPackage", "com.mdi.azlottery");
            //capabilities.SetCapability("appActivity", "com.mdi.azlottery.MainActivity");
            //capabilities.SetCapability("app", "D:\\downloads-sw\\apk-apps\\AZApp-5.1.1.apk");
            capabilities.SetCapability("appPackage", "com.android.calculator2");
            capabilities.SetCapability("appActivity", "com.android.calculator2.Calculator");

            //capabilities.SetCapability("NEW_COMMAND_TIMEOUT", "10000");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);

            driver.FindElementById("com.android.calculator2:id/digit_7").Click();                        //7 using id 
            driver.FindElementByClassName("android.widget.Button").Click();                              //7 using class name
            driver.FindElementByXPath("//android.widget.Button[@content-desc='plus']").Click();          //+ using xpath of content-desc
            driver.FindElementByName("8").Click();                                                       //8 using name/text 
            driver.FindElementByXPath("//android.widget.Button[@text='6' and @index='5']").Click();      //6 using xpath of text and index together

            driver.FindElementByXPath("//android.widget.Button[@content-desc='times']").Click();          //* using xpath of content-desc
            driver.FindElementByName("2").Click();                                                        //2 using name/text 
            driver.FindElementById("com.android.calculator2:id/eq").Click();                              //= using id

        }

        public void MaryLandLottery()
        {
            capabilities.SetCapability("deviceName", "emulator-5554");
            capabilities.SetCapability(CapabilityType.Version, "6.0");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            capabilities.SetCapability("appPackage", "com.mdi.mdlottery");
            capabilities.SetCapability("appActivity", "com.mdi.mdlottery.MainActivity");
            capabilities.SetCapability("app", "D:\\downloads-sw\\apk-apps\\mdNativeApp.apk");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            capabilities.SetCapability("NEW_COMMAND_TIMEOUT", "100000");
            Thread.Sleep(20000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25000));
            IWebElement register =  driver.FindElementByXPath("//android.view.View[@content-desc='REGISTER NOW']");
            wait.Until(ExpectedConditions.ElementToBeClickable(register));
            //register.Click();
            Thread.Sleep(2000);



            IWebElement FN = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Legal First Name:']");
            wait.Until(ExpectedConditions.ElementToBeClickable(FN));
            FN.SendKeys("suparna");
            driver.HideKeyboard();

            IWebElement MN = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Middle Initial:']");
            MN.SendKeys("s");
            driver.HideKeyboard();

            IWebElement LN = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Legal Last Name:']");
            LN.SendKeys("khamaru");
            driver.HideKeyboard();

            IWebElement address1 = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Address:']");
            address1.SendKeys("itpl, bangalore, india");
            driver.HideKeyboard();

            driver.GetScreenshot().SaveAsFile("C:\\Users\\104919\\Videos\\screenshots\\mslottery.Jpeg", ScreenshotImageFormat.Jpeg);

            driver.Zoom(address1);
            driver.Zoom(400, 600);
            //driver.Pinch(25, 25);
            //driver.Pinch(address1);

            int Height = driver.Manage().Window.Size.Height; //1776
            int Width = driver.Manage().Window.Size.Width;  //1080

            int Starty = (int)(Height / 2);                   //886.5
            int Endy = (int)(Height * 0.90);                 //1243
            int Startx = (int)(Width / 2);                   // 540

            driver.Swipe(Startx, Endy, Startx, Starty, 1000); //top to bottom
            // driver.Swipe(Startx, Starty, Startx, Endy, 1000); //bottom to top 

            IWebElement Zip = driver.FindElementByXPath("//android.widget.EditText[@content-desc='ZIP Code:']");
            Zip.SendKeys("56006");
            driver.HideKeyboard();
            driver.Swipe(Startx, Endy, Startx, Starty, 1000);

            IWebElement PreferredContact = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Preferred Contact #:']");
            PreferredContact.SendKeys("8888888888");
            driver.HideKeyboard();
            driver.Swipe(Startx, Endy, Startx, Starty, 1000);

            IWebElement MobileNumber = driver.FindElementByXPath("//android.widget.EditText[@content-desc='Mobile #:']");
            MobileNumber.SendKeys("9876543210");
            driver.HideKeyboard();
            // driver.Swipe(Startx, Endy, Startx, Starty, 1000); 

            IWebElement DOB_Month = driver.FindElementByXPath("//android.widget.Spinner[@content-desc='Month']");
            DOB_Month.Click();
            IWebElement dob_month_select = driver.FindElementByName("May");
            dob_month_select.Click();

            IWebElement DOB_Day = driver.FindElementByXPath("//android.widget.Spinner[@content-desc='Day']");
            DOB_Day.Click();
            driver.Swipe(Startx, Endy, Startx, Starty, 1000);
            driver.Swipe(Startx, Endy, Startx, Starty, 1000);
            IWebElement dob_day_select = driver.FindElementByName("14");
            dob_day_select.Click();

            IWebElement DOB_Year = driver.FindElementByXPath("//android.widget.Spinner[@content-desc='Year']");
            DOB_Year.Click();
            driver.Swipe(Startx, Endy, Startx, Starty, 1000);
            IWebElement dob_year_select = driver.FindElementByName("1990");
            dob_year_select.Click();

            IWebElement certifyCheckbox = driver.FindElementByXPath("//android.widget.CheckBox[@content-desc='I certify that I am 18 years of age or older.']");
            certifyCheckbox.Click();


            IWebElement genderSelect = driver.FindElementByXPath("//android.widget.RadioButton[@content-desc='Female']");
            genderSelect.Click();

            int Endy1 = (int)(Height / 2);          //888       
            int Startx1 = (int)(Width * 0.30);        //108
            int Endx1 = (int)(Width * 0.90);          //972
            driver.Swipe(Startx1, Endy1, Endx1, Endy1, 200); //left to right swipe
            Thread.Sleep(5000);
            //driver.Swipe(Endx1, Endy1, Startx1, Endy1, 1000); //right to left swipe --> not working 
            
        }








        //public static void Main(string[] args)
        //{
        //    Program pg = new Program();
        //    //pg.AZLottery();
        //    //pg.calculator();
        //   // pg.MaryLandLottery();
        //}

    }
}