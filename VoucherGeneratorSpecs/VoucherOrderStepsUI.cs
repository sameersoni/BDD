using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
//add this name space to access WebDriverWait
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace VoucherGeneratorSpecs
{
    [Binding]
    public class VoucherOrderStepsUI
    {
        public static IWebDriver WebDriver;
        private string _country;

        // Use TestInitialize to run code before running each test
        [BeforeScenario("web")]
        public void MyTestInitialize()
        {
            WebDriver = new ChromeDriver("C:\\Users\\Sameer Soni\\Downloads\\chromedriver_win32");
        }
        [AfterScenario("web")]
        public void MyTestCleanup()
        {
            WebDriver.Quit();
        }

        [Given(@"Following countries"), Scope(Tag="web")]
        public void GivenFollowingCountries(Table table)
        {
        }

        [Given(@"the client is from (.*)"), Scope(Tag = "web")]
        public void GivenTheClientIsFromUI(String country)
        {
            _country = country;
        }

        [When(@"the client wants to order vouchers"), Scope(Tag = "web")]
        public void WhenTheClientWantsToOrderVouchersUI()
        {
            WebDriver.Navigate().GoToUrl("http://192.168.109.1:3000/order/new?country=" + _country);
        }

        [When(@"the client orders the following vouchers"), Scope(Tag = "web")]
        public void WhenTheClientOrdersTheFollowingVouchersUI(Table table)
        {
            foreach (var row in table.Rows)
            {
                var fieldName = "denominations_" + row[0];
                var fieldValue = row[1];
                var pageElement = WebDriver.FindElement(By.Id(fieldName));
                pageElement.SendKeys(fieldValue);
            }
        }

        [When(@"the order is approved"), Scope(Tag = "web")]
        public void WhenTheOrderIsApprovedUI()
        {
        }

        [Then(@"the display currency should be (.*)"), Scope(Tag = "web")]
        public void ThenTheDisplayCurrencyShouldBeUI(string currency)
        {
            var currencyUI = WebDriver.FindElement(By.ClassName("currency")).Text;
            Assert.AreEqual(currencyUI, currency);
        }

        [Then(@"the order currency should be (.*)"), Scope(Tag = "web")]
        public void ThenTheOrderCurrencyShouldBeUI(string currency)
        {
            //Assert.AreEqual(currency, _order.Currency);
        }

        [Then(@"the selectable voucher denominations should be (.*)"), Scope(Tag="web")]
        public void ThenTheSelectableVoucherDenominationsShouldBeUI(string denominationsCsv)
        {
            // var denominations = denominationsCsv.Split(',').Select(x => x.Trim());
            //foreach (var denomination in denominations)
            //{
            //    var selector = "value_" + denomination.ToString;
            //    var element = WebDriver.FindElement(By.Id(selector));
            //    Assert.AreEqual(element.Text.Trim, denomination.ToString);
            //}
        }

        [Then(@"the total face value should be (.*)"), Scope(Tag = "web")]
        public void ThenTheTotalFaceValueShouldBe(int faceValue)
        {
            //Assert.AreEqual(faceValue, _order.TotalFaceValue);
        }

        [Then(@"the total number of vouchers should be (.*)"), Scope(Tag = "web")]
        public void ThenTheTotalNumberOfVouchersShouldBe(int voucherCount)
        {
            //Assert.AreEqual(voucherCount, _order.VoucherCount);
        }

        [Then(@"the order should be sent for approval by staff"), Scope(Tag = "web")]
        public void ThenTheOrderShouldBeSentForApprovalByStaff()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the following vouchers should be generated"), Scope(Tag = "web")]
        public void ThenTheFollowingVouchersShouldBeGenerated(Table table)
        {
            //var voucherSet = new VoucherSet(_order);
            foreach (var tableRow in table.Rows)
            {
            //    Assert.AreEqual(voucherSet.VouchersOf(int.Parse(tableRow[0])).Count, int.Parse(tableRow[1]));
            }
        }

        [Then(@"each voucher code should be (.*) characters long"), Scope(Tag = "web")]
        public void ThenEachVoucherCodeShouldBeCharactersLong(int voucherCodeLength)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"each voucher code should have alphanumeric characters"), Scope(Tag = "web")]
        public void ThenEachVoucherCodeShouldHaveAlphanumericCharacters()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
