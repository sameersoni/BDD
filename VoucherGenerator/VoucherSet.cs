using System.Collections.Generic;

namespace VoucherGeneratorSpecs
{
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
}