using DemoMobileAutomation.TestData.AndroidApps.mdLottery;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DemoMobileAutomation.TestCases.AndroidApps.mdLottery
{
   public class ReadeMailinWeb
    {
       IWebDriver driver;
       
           //public static void Main(string[] args)
           //{
           //    ReadeMailinWeb readmail = new ReadeMailinWeb();
           //    readmail.Execute();
           //}
            

           public void Execute()
           {
               driver = new FirefoxDriver();
               driver.Manage().Window.Maximize();
               driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30000);
               driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?service=mail&passive=true&rm=false&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

               IWebElement enterEmailID = driver.FindElement(By.Id("identifierId")); 
               enterEmailID.Click();
               enterEmailID.SendKeys("demo.scen" + Keys.Enter); Thread.Sleep(3000);
               IWebElement enterPassword = driver.FindElement(By.Name("password"));
               
               enterPassword.Click();
               enterPassword.SendKeys("scentrics123" + Keys.Enter); Thread.Sleep(10000);
               IList<IWebElement> listOfMails = driver.FindElements(By.XPath("//*[@class='F cf zt']/tbody/tr"));
               int emailSize=listOfMails.Count();

               for (int i = 2; i < emailSize; i++)
               {             
                       IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                       executor.ExecuteScript("arguments[0].click();", listOfMails.ElementAt(i)); Thread.Sleep(2000);
                      // executor.ExecuteScript("alert('Hello Suparna');");
                     

                            string emailBody = driver.FindElement(By.XPath("//div[@class='ii gt adP adO']/div")).Text;
                            int pos1 = emailBody.IndexOf("!");
                            int pos2 = emailBody.IndexOf("once.");
                            string values = emailBody.Substring(pos2+6, 16);
                            values = values.Trim();
                         
                        driver.FindElement(By.XPath("//div[@class='ii gt adP adO']/div/p[3]/a")).Click();
                       
                      //  driver.SwitchTo().Window("_blank");
                        //foreach (string handle in driver.WindowHandles)
                        //{
                        //    driver.SwitchTo().Window(handle);
                        //}
                         
               }
               driver.Close();

           }

           


    }
}
