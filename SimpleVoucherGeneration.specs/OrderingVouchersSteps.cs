using System;
using TechTalk.SpecFlow;

namespace SimpleVoucherGeneration.specs
{
    [Binding]
    public class OrderingVouchersSteps
    {
        [Given(@"I have mentioned the total amount")]
        public void GivenIHaveMentionedTheTotalAmount()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have specified equivalent denomination values")]
        public void GivenIHaveSpecifiedEquivalentDenominationValues()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press buy")]
        public void WhenIPressBuy()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the validation result should appear on screen")]
        public void ThenTheValidationResultShouldAppearOnScreen()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
