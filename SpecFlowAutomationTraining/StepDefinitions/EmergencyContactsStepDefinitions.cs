using OpenQA.Selenium;
using SpecFlowAutomationTraining.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomationTraining.StepDefinitions
{
    [Binding]
    public class EmergencyContactsStepDefinitions
    {
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();
        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Emergency Contacts']")).Click();
        }

        [When(@"I click on Add Assigned Emergency Contacts")]
        public void WhenIClickOnAddAssignedEmergencyContacts()
        {
            
            AutomationHooks.driver.FindElement(By.XPath("//h6[text()='Assigned Emergency Contacts']/following::button")).Click();
        }

        [When(@"I fill emergency contact details")]
        public void WhenIFillEmergencyContactDetails(Table table)
        {
            string name = table.Rows[0]["contact_name"];
            string relationship = table.Rows[0]["relationship"];
            string home_telephone = table.Rows[0]["home_telephone"];
            string mobile = table.Rows[0]["mobile"];
            string work_telephone = table.Rows[0]["work_telephone"];

            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Name']/following::input")).SendKeys(name);
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Relationship']/following::input")).SendKeys(relationship);
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Home Telephone']/following::input")).SendKeys(home_telephone);
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Mobile']/following::input")).SendKeys(mobile);
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Work Telephone']/following::input")).SendKeys(work_telephone);
        }

        [When(@"I click on save Emergency Contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
            AutomationHooks.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should see the added records in the table")]
        public void ThenIShouldSeeTheAddedRecordsInTheTable()
        {
            Console.WriteLine();
        }
    }
}
