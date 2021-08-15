
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VicRoads_Specflow_POM.Pages
    {
        public class UvvStep2Of7Page
        {
            public UvvStep2Of7Page()
            {
                PageFactory.InitElements(Browser.Current, this);
            }
            [FindsBy(How = How.ClassName, Using = "progress-bar-title")]
            public IWebElement Selectpermittype;
            public bool status;
            public Boolean ValidateselectpermitIsVisible()
            {
                status = Selectpermittype.Displayed;
                return status;
            }

        }
    }


