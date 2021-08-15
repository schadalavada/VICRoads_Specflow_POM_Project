using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using VicRoads_Specflow_POM.Pages;
using VicRoads_Specflow_Project.Pages;

namespace VicRoads_Specflow_Project.StepDefinitions
{
    [Binding]
    class ValidatingSelectPermitTypeUvp2of7steps


    {

        IWebDriver currentDriver = null;
        
        UvvStep1Of7Page uvv1of7page = new UvvStep1Of7Page();
        UvvStep2Of7Page uvv2of7page = new UvvStep2Of7Page();

        [Given(@"I have navigated to the UVP 1 of 7 page")]
        public void GivenIHaveNavigatedToTheUvp1Of7Page()
        {
            Browser.Current.Navigate().GoToUrl("https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit")
        }

        [When(@"I select Vehicle type  as \""(.*)""")]
        public void WhenISelect(string vehicletype)
        {
            uvv1of7page.SelectVehicleType(vehicletype);
        }

        [When(@"I enter  Address as \""(.*)""")]
        public void WhenIEnterAs(string text1, string text2)
        {
            uvv1of7page.EnterAddress(text1, text2);
        }

        [When(@"I select permit start date as \""(.*)""")]
        public void WhenISelectpermittype(string permitstdt)
        {
            uvv1of7page.permitStartDate(permitstdt);

        }

        [When(@"I select permit duration as \""(.*)""")]
        public void WhenISelectpermitduration(string permitdn)
        {
            uvv1of7page.permitDuration(permitdn);
        }


        [When(@"I click on next button on UVP 1 of 7 page")]
        public void WhenIClickOnNextButton()
        {
            uvv1of7page.ClickNext();
        }

        [Then(@"User should be navigated to UVP Step 2 of 7 Page and Select permit type text is displayed")]
        public void ThenVerifySelectPermitTypeText()
        {
            bool actual = uvv2of7page.ValidateselectpermitIsVisible();
            Assert.IsTrue(actual);
            System.Console.WriteLine("Select permit is displayed");



        }

    }
}

