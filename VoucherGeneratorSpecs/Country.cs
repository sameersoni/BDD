using System.Collections.Generic;
using System.Linq;

namespace VoucherGeneratorSpecs
{
    public class Country
    {
        public string Name { get; private set; }
        public string Currency { get; private set; }
        public IEnumerable<int> Denominations { get; private set; }

        public Country(string name, string currency, string denominationsCsv)
        {
            Name = name;
            Currency = currency;
            Denominations = denominationsCsv.Split(',').Select(x => int.Parse(x.Trim()));
        }
    }
}