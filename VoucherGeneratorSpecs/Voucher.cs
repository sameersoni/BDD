namespace VoucherGeneratorSpecs
{
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