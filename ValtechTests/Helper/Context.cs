using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ValtechTests.Helper
{
    public class Context
    {
        public IWebDriver Driver;
       // private string BaseUrl= "https://www.valtech.com";
        private string BaseUrl = "https://www.argusmedia.com/";

        public void BrowserSetup()
        {
            var chromeDriverProcesses = Process.GetProcessesByName("ChromeDriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                try
                {
                    chromeDriverProcess.Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(BaseUrl);
            Driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            Driver.Quit();
            Driver.Dispose();
        }


        public void DropDownSelection(IWebElement element, int text) {

            SelectElement dropdownText = new SelectElement(element);
            dropdownText.SelectByIndex(text);
        }
    }
    
}
