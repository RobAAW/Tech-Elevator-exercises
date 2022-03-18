using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyByNight_3_1_Test.PageObjects
{
    public class HomePage
    {
        private IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public MortgageCalculatorInputPage clickMortgageCalculatorLink()
        {
            IWebElement calculatorLink = webDriver.FindElement(By.LinkText("Mortgage Payment Calculator"));
            calculatorLink.Click();
            return new MortgageCalculatorInputPage(webDriver);
        }

    }
}
