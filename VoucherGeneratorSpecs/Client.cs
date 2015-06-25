namespace VoucherGeneratorSpecs
{
    public class Client
    {
        public Country Country { get; private set; }

        public Client(Country country)
        {
            Country = country;
        }
    }
}