﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace SpecFlowAutomationTraining.Hooks
{
    [Binding]
    public class AutomationHooks
    {
        public static IWebDriver driver;

        //runs after each scenario wether scenario passed or fail.  
        [AfterScenario]
        public void EndScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
