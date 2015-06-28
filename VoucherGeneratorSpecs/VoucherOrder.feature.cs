﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.33440
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace VoucherGeneratorSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Mobile voucher order")]
    public partial class MobileVoucherOrderFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "VoucherOrder.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Mobile voucher order", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
  #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Country",
                        "Currency",
                        "Denominations",
                        "VoucherCodeLength"});
            table1.AddRow(new string[] {
                        "Singapore",
                        "SGD",
                        "5, 10, 20, 50",
                        "5"});
            table1.AddRow(new string[] {
                        "India",
                        "INR",
                        "5, 10, 20, 50, 100",
                        "6"});
#line 5
 testRunner.Given("Following countries", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Order voucher form")]
        [NUnit.Framework.CategoryAttribute("app")]
        [NUnit.Framework.CategoryAttribute("app")]
        [NUnit.Framework.TestCaseAttribute("Singapore", "SGD", "5, 10, 20, 50", null)]
        [NUnit.Framework.TestCaseAttribute("India", "INR", "5, 10, 20, 50, 100", null)]
        public virtual void OrderVoucherForm(string country, string currency, string denominations, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "app",
                    "app"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Order voucher form", @__tags);
#line 11
  this.ScenarioSetup(scenarioInfo);
#line 4
  this.FeatureBackground();
#line 12
    testRunner.Given(string.Format("the client is from {0}", country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("the client wants to order vouchers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
    testRunner.Then(string.Format("the display currency should be {0}", currency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
    testRunner.And(string.Format("the selectable voucher denominations should be {0}", denominations), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Submit voucher orders")]
        [NUnit.Framework.CategoryAttribute("app")]
        public virtual void SubmitVoucherOrders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Submit voucher orders", new string[] {
                        "app"});
#line 23
  this.ScenarioSetup(scenarioInfo);
#line 4
  this.FeatureBackground();
#line 24
    testRunner.Given("the client is from Singapore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "denomination",
                        "quantity"});
            table2.AddRow(new string[] {
                        "5",
                        "100"});
            table2.AddRow(new string[] {
                        "10",
                        "150"});
            table2.AddRow(new string[] {
                        "50",
                        "200"});
#line 25
    testRunner.When("the client orders the following vouchers", ((string)(null)), table2, "When ");
#line 30
    testRunner.Then("the total face value should be 12000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
    testRunner.And("the total number of vouchers should be 450", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("the order currency should be SGD", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Approve voucher orders")]
        [NUnit.Framework.CategoryAttribute("app")]
        public virtual void ApproveVoucherOrders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Approve voucher orders", new string[] {
                        "app"});
#line 36
  this.ScenarioSetup(scenarioInfo);
#line 4
  this.FeatureBackground();
#line 37
    testRunner.Given("the client is from Singapore", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "denomination",
                        "quantity"});
            table3.AddRow(new string[] {
                        "5",
                        "100"});
            table3.AddRow(new string[] {
                        "10",
                        "150"});
            table3.AddRow(new string[] {
                        "50",
                        "200"});
#line 38
    testRunner.When("the client orders the following vouchers", ((string)(null)), table3, "When ");
#line 43
    testRunner.And("the order is approved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "denomination",
                        "quantity"});
            table4.AddRow(new string[] {
                        "5",
                        "100"});
            table4.AddRow(new string[] {
                        "10",
                        "150"});
            table4.AddRow(new string[] {
                        "50",
                        "200"});
#line 44
    testRunner.Then("the following vouchers should be generated", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
