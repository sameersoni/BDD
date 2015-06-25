using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace VoucherGeneratorSpecs
{
    [Binding]
    public class VoucherOrderSteps
    {
        private String country = null;
        private Client client = null;
        IEnumerable<Country> countries;
        private Order _order;

        [Given(@"Following countries")]
        public void GivenFollowingCountries(Table table)
        {
            countries = table.Rows.Select(row => new Country(row[0], row[1], row[2]));
        }

        [Given(@"the client is from (.*)")]
        public void GivenTheClientIsFrom(String country)
        {
            this.client = new Client(countries.First(x => x.Name.Equals(country)));
        }
        
        [When(@"the client wants to order vouchers")]
        public void WhenTheClientWantsToOrderVouchers()
        {
        }

        [When(@"the client orders the following vouchers")]
        public void WhenTheClientOrdersTheFollowingVouchers(Table table)
        {
            _order = new Order(client, table.Rows.Select(row => new LineItem(int.Parse(row[0]), int.Parse(row[1]))));
        }
        
        [When(@"the order is approved")]
        public void WhenTheOrderIsApproved()
        {
        }
        
        [Then(@"the display currency should be (.*)")]
        public void ThenTheDisplayCurrencyShouldBe(string currency)
        {
            Assert.AreEqual(currency, client.Country.Currency);
        }

        [Then(@"the order currency should be (.*)")]
        public void ThenTheOrderCurrencyShouldBe(string currency)
        {
            Assert.AreEqual(currency, _order.Currency);
        }

        [Then(@"the selectable voucher denominations should be (.*)")]
        public void ThenTheSelectableVoucherDenominationsShouldBe(string denominationsCsv)
        {
            var denominations = denominationsCsv.Split(',').Select(x => int.Parse(x.Trim()));
            Assert.AreEqual(denominations, client.Country.Denominations);
        }

        [Then(@"the total face value should be (.*)")]
        public void ThenTheTotalFaceValueShouldBe(int faceValue)
        {
            Assert.AreEqual(faceValue, _order.TotalFaceValue);
        }
        
        [Then(@"the total number of vouchers should be (.*)")]
        public void ThenTheTotalNumberOfVouchersShouldBe(int voucherCount)
        {
            Assert.AreEqual(voucherCount, _order.VoucherCount);
        }
        
        [Then(@"the order should be sent for approval by staff")]
        public void ThenTheOrderShouldBeSentForApprovalByStaff()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the following vouchers should be generated")]
        public void ThenTheFollowingVouchersShouldBeGenerated(Table table)
        {
            var voucherSet = new VoucherSet(_order);
            foreach (var tableRow in table.Rows)
            {
                Assert.AreEqual(voucherSet.VouchersOf(int.Parse(tableRow[0])).Count, int.Parse(tableRow[1]));
            }
        }
        
        [Then(@"each voucher code should be (.*) characters long")]
        public void ThenEachVoucherCodeShouldBeCharactersLong(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"each voucher code should have alphanumeric characters")]
        public void ThenEachVoucherCodeShouldHaveAlphanumericCharacters()
        {
            ScenarioContext.Current.Pending();
        }
    }

    public class VoucherSet
    {
        public Order Order { get; private set; }

        public List<Voucher> Vouchers { get; private set; }

        public VoucherSet(Order order)
        {
            Order = order;
            CreateVouchers();
        }

        public List<Voucher> VouchersOf(int amount)
        {
            return Vouchers.FindAll(v => v.Value == amount);
        }

        private void CreateVouchers()
        {
            Vouchers = new List<Voucher>();
            foreach (var lineItem in Order.LineItems)
            {
                for (var i = 0; i < lineItem.Quantity; i++)
                {
                    Vouchers.Add(new Voucher(Order.Currency, lineItem.Denomination));
                }
            }
        }
    }

    public class Voucher
    {
        public string Currency { get; private set; }
        public int Value { get; private set; }

        public Voucher(string currency, int value)
        {
            Currency = currency;
            Value = value;
        }
    }
}
