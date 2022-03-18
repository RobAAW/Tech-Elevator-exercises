using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyByNight_3_1_Test.PageObjects
{
    public class MortgageCalculatorResultPage
    {
        private IWebDriver webDriver;

        public MortgageCalculatorResultPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public String getPaymentAmount()
        {
            return webDriver.FindElement(By.XPath("//table[@id=\"loanPaymentCalculationResults\"]//tr[4]/td")).Text;
        }

        public String getTitle()
        {
            return webDriver.Title;
        }
    }
}
