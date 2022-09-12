using OpenQA.Selenium;
using SpecFlowAutomationTraining.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomationTraining.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        string fName;
        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        }

        [When(@"I fill the add employee section")]
        public void WhenIFillTheAddEmployeeSection(Table table)
        {
            fName = table.Rows[0]["firstname"];
            string mName = table.Rows[0]["middlename"];
            string lName = table.Rows[0]["lastname"];
            string empId = table.Rows[0]["employee_id"];
            string toggleLoginDetail = table.Rows[0]["toggle_login_detail"];
            string userName = table.Rows[0]["username"];
            string password = table.Rows[0]["password"];
            string confirmPassword = table.Rows[0]["confirm_password"];
            string status = table.Rows[0]["status"];


            AutomationHooks.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            AutomationHooks.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            AutomationHooks.driver.FindElement(By.Name("lastName")).SendKeys(lName);
            if (toggleLoginDetail.Equals("on"))
            {
                AutomationHooks.driver.FindElement(By.XPath("//span[contains(@class,'oxd-switch-input')]")).Click();
                AutomationHooks.driver.FindElement(By.XPath("//label[text()='Username']/following::input")).SendKeys(userName);
                AutomationHooks.driver.FindElement(By.XPath("//label[text()='Password']/following::input")).SendKeys(password);
                AutomationHooks.driver.FindElement(By.XPath("//label[text()='Confirm Password']/following::input")).SendKeys(confirmPassword);

                if (status.Equals("enabled"))
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Enabled']//span")).Click();
                }
                else
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Disabled']//span")).Click();
                }
            }
        }

        [When(@"I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should be navigate to personal section with added emplyee records")]
        public void ThenIShouldBeNavigateToPersonalSectionWithAddedEmplyeeRecords()
        {
            string actualFirstName = AutomationHooks.driver.FindElement(By.Name("firstName")).GetAttribute("value");
            Assert.Equal(fName, actualFirstName);
        }
    }
}
