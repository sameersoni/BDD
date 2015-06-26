using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
//add this name space to access WebDriverWait
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace AutomationUsingSelenium
{
    [TestClass]
    public class SeleniumTest
    {

        public static IWebDriver WebDriver;

        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            WebDriver = new ChromeDriver("C:\\Users\\Sameer Soni\\Downloads\\chromedriver_win32");
        }

        [TestMethod]
        public void TestUserCanSignIntoThePortal()
        {
            WebDriver.Navigate().GoToUrl("http://192.168.2.102:3000/member/sign_in");
            var emailField = WebDriver.FindElement(By.Id("member_email"));
            var passwordField = WebDriver.FindElement(By.Id("member_password"));
            emailField.Clear();
            emailField.SendKeys("test@test.com");
            passwordField.Clear();
            passwordField.SendKeys("12345678");
            var submitButton = WebDriver.FindElement(By.Name("commit"));
            submitButton.Click();

            var welcomeMessage = WebDriver.FindElement(By.ClassName("welcome-message"));
            Assert.AreEqual(welcomeMessage.Text.Contains("Welcome"), true);

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            WebDriver.Quit();
        }
    }
}
