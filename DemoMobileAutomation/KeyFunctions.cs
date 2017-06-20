using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMobileAutomation
{
    public class KeyFunctions
    {
        public static AppiumDriver<AndroidElement> idriver;

        public KeyFunctions(AppiumDriver<AndroidElement> driver)
        {
            idriver = driver;
        }

        public void mdLotteryCapabilities(DesiredCapabilities capabilities)
        {
            capabilities.SetCapability("deviceName", ConfigurationManager.AppSettings["deviceName"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["Version"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["BrowserName"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["Platform"]);
            capabilities.SetCapability("appPackage", ConfigurationManager.AppSettings["mdLotteryPackage"]);
            capabilities.SetCapability("appActivity", ConfigurationManager.AppSettings["mdLotteryActivity"]);
            capabilities.SetCapability("app", ConfigurationManager.AppSettings["mdLotteryapp"]);

        }
    }
}
