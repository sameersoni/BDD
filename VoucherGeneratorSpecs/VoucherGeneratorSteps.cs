using NUnit.Framework;
using TechTalk.SpecFlow;

namespace VoucherGeneratorSpecs
{
    [Binding]
    public class VoucherGenerationSteps
    {

        VoucherGenerator.VoucherGenerator _generator = new VoucherGenerator.VoucherGenerator();

        [Given(@"I have entered denominations details")]
        public void GivenIHaveEnteredDenominationsDetails()
        {
            _generator.SetDenominations(10, 2, 3, 5);
        }
        
        [When(@"I press Done")]
        public void WhenIPressDone()
        {
            _generator.CalculatePayment();
        }
        
        [Then(@"I should see total amount \$(.*) and message that says ""(.*)""")]
        public void ThenIShouldSeeTotalAmountAndMessageThatSays(int p0, string p1)
        {
            Assert.AreEqual(_generator.AmountToPay, 100);
            Assert.AreEqual(_generator.PaymentMessage, "Proceed for Payment");
        }
    }
}
