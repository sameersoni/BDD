using System.Collections.Generic;
using System.Linq;

namespace VoucherGeneratorSpecs
{
    public class Order
    {
        public Client Client { get; set; }
        public IEnumerable<LineItem> LineItems { get; set; }
        public int TotalFaceValue
        {
            get { return LineItems.Sum(item => item.Denomination * item.Quantity); }
        }

        public int VoucherCount
        {
            get { return LineItems.Sum(item => item.Quantity); }
        }

        public string Currency
        {
            get { return Client.Country.Currency; }
        }

        public Order(Client client, IEnumerable<LineItem> lineItems)
        {
            Client = client;
            LineItems = lineItems;
        }
    }
}