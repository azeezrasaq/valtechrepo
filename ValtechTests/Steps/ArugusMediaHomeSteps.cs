using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ValtechTests.Helper;
using ValtechTests.Pages;

namespace ValtechTests.Steps
{
    [Binding]
   public  class ArugusMediaHomeSteps
    {
        private readonly Context context;
        private readonly ArgusMediaHomePage argusmediahomepage; 

        public ArugusMediaHomeSteps(Context contex, ArgusMediaHomePage argusmedia) {

            context = contex;
            argusmediahomepage = argusmedia;
        }




        [Given(@"i am on argus home page")]
        public void GivenIAmOnArgusHomePage()
        {
            context.BrowserSetup();
        }

        [When(@"i select what market i am looking for")]
        public void WhenISelectWhatMarketIAmLookingFor()
        {
            argusmediahomepage.YourMarket();
            argusmediahomepage.WhatYouLookFor();
            argusmediahomepage.SelectionThree();
        }

        [Then(@"i should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            context.CloseBrowser(); 
        }

    }
}
