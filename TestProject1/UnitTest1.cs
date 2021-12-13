using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using TestProject1.Pages;

namespace TestProject1
{
    public class Tests : DriverHelper
    {
        

        [SetUp]
        public void startBrowser()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("headless");

            driver = new ChromeDriver(opt);
        }

        
        public void test()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");
            CustomControl.Click(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");


        }

        [Test]
        public void TestMethod()
        {
            HomePage homePage = new HomePage();
            homePage.ClickVisitNow();
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();


            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.IsLogOffButtonExist, Is.True, "Log off button is not displayed");

        }

        [Test]
        public void RegistrationTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            RegisterPage registerPage = new RegisterPage();

            homePage.ClickRegister();

            Assert.AreEqual(registerPage.registerPageUrl, "http://eaapp.somee.com/Account/Register","Register url incorrect");

            registerPage.EnterRegistrationDetails("adamtestuser1","TestPass123", "TestPass123", "test@testadam.com");
            registerPage.ClickRegister();
        }

        [Test]
        public async Task AsynRegTest()
        {
            string urlinasync = await TestAsync1();
            Assert.IsNotEmpty(urlinasync);
            Console.Write("Result URL is: " + urlinasync);
        }
       
        public async Task<string> TestAsync1()
        {
            string url = String.Empty;
            await Task.Run(() =>
            {
                RegisterPage registerPage = new RegisterPage();
                url = registerPage.registerPageUrl;
               
            });
            return url;
        }




        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}