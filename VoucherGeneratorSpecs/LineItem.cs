namespace VoucherGeneratorSpecs
{
    public class LineItem
    {
        public LineItem(int denomination, int quantity)
        {
            Denomination = denomination;
            Quantity = quantity;
        }

        public int Denomination { get; private set; }
        public int Quantity { get; private set; }
    }
}