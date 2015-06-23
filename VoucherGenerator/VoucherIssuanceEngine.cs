using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherGenerator
{
    public class VoucherGenerator
    {

        public int AmountToPay { get; set; }
        public int multiple { get; set; }
        private int[] values;
        public String PaymentMessage;
        
        public void SetDenominations(int multiple, params int[] values)
        {
            this.multiple = multiple;
            this.values = values;
        }

        public void CalculatePayment()
        {
            foreach (var value in values)
            {
                AmountToPay += value*multiple;
            }
            PaymentMessage = "Proceed for Payment";
        }

    }
}
