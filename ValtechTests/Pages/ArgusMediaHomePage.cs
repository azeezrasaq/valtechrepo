using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtechTests.Helper;

namespace ValtechTests.Pages
{
   public class ArgusMediaHomePage
    {
       private readonly Context _context;
       public ArgusMediaHomePage(Context context)
        {
            _context = context;
        }

       private By MARKETELEMENTClick = By.XPath("//*[@class='text' and text()='1. What is your market?']");
       private By LOOKINGFORCLICK = By.CssSelector("//*[@class='text' and text()='2. What are you looking for?']");
       private By SelectThreeClick = By.CssSelector("//*[@class='text' and text()='3. Select']");

       private By MARKETELEMENT = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[1]/div/select");
       private By LOOKINGFOR = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[2]/div/select");
       private By SelectThree = By.XPath("//*[@id='main']/section[1]/div[2]/div/fieldset/div[3]/div/select");
       
       
       public void YourMarket() {
           _context.Driver.FindElement(MARKETELEMENTClick).Click();
           IWebElement dropdowText = _context.Driver.FindElement(MARKETELEMENT);
           _context.DropDownSelection(dropdowText, 2);
       }

       public void WhatYouLookFor() {
           _context.Driver.FindElement(LOOKINGFORCLICK).Click();
           IWebElement dropdowText = _context.Driver.FindElement(LOOKINGFOR);
           _context.DropDownSelection(dropdowText, 2);
       }

       public void SelectionThree()
       {
           _context.Driver.FindElement(SelectThreeClick).Click();
           IWebElement dropdowText = _context.Driver.FindElement(SelectThree);
           _context.DropDownSelection(dropdowText, 1);
       }
    }
}
