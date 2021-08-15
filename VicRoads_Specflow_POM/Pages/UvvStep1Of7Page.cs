using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using VicRoads_Specflow_POM.Pages;

namespace VicRoads_Specflow_Project.Pages
{
   public class UvvStep1Of7Page 
    {
        public UvvStep1Of7Page()
        {
            PageFactory.InitElements(Browser.Current, this);
        }
        [FindsBy(How = How.Id, Using = "ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitStartDate_Date")]
        public IWebElement PermitStartDate;

        [FindsBy(How = How.Id, Using = "ph_pagebody_0_phthreecolumnmaincontent_0_panel_btnNext")]
        public IWebElement next;
        public void enterDataInTheUvpStep1of(string VehicleType,string enterAddress,string compareAddress,string permitStartDt,string permitDtn)
        {
            SelectVehicleType(VehicleType);
            EnterAddress(enterAddress, compareAddress);
            permitStartDate(permitStartDt);
            permitDuration(permitDtn);
            ClickNext();

        }


        public void SelectVehicleType(String VehicleType)
        {

            string javascript = "return document.getElementById('ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList');";
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.Current;

            IWebElement element = (IWebElement)js.ExecuteScript(javascript);
            System.Threading.Thread.Sleep(3000);

            SelectElement Securityquestionvalue = new SelectElement(element);

            Securityquestionvalue.SelectByIndex(3);
        }




        public void EnterAddress(String addressenterval, String compaddressval)
        {
            IWebElement address = Browser.Current.FindElement(By.Id("ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown"));
            address.SendKeys(addressenterval);
            System.Threading.Thread.Sleep(3000);
            IWebElement autoOptions = Browser.Current.FindElement(By.Id("ui-id-1"));


            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(Browser.Current);
            fluentWait.Timeout = System.TimeSpan.FromSeconds(5);
            IWebElement SearchResult = fluentWait.Until(x => x.FindElement(By.Id("ui-id-1")));

            IList<IWebElement> displayedOptions = autoOptions.FindElements(By.TagName("li"));

            foreach (IWebElement option in displayedOptions)
            {
                string gettext = option.Text;
                if (gettext.Equals(compaddressval))
                {
                    System.Console.WriteLine("Trying to select: " + compaddressval);
                    option.Click();
                    System.Threading.Thread.Sleep(3000);
                }
            }

        }

        public void permitStartDate(String permitstdt)
        {

            PermitStartDate.Clear();
            PermitStartDate.SendKeys(permitstdt);
            System.Threading.Thread.Sleep(3000);

        }


        public void permitDuration(String permitdurn)
        {

            string javascript22 = "return document.getElementById('ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList');";

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)Browser.Current;

            IWebElement element1 = (IWebElement)js1.ExecuteScript(javascript22);
            System.Threading.Thread.Sleep(3000);

            SelectElement Securityquestionvalue11 = new SelectElement(element1);

            Securityquestionvalue11.SelectByIndex(17);
            System.Threading.Thread.Sleep(3000);
        }

        public UvvStep2Of7Page ClickNext()
        {
            next.Click();
            return new UvvStep2Of7Page();
        }
    }
}
