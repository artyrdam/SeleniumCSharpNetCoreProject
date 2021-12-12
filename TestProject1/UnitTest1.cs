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
            /*ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("headless");
            driver = new ChromeDriver(opt);*/
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");
            CustomControl.Click(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            CustomControl.SelectByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");


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

           // Assert.That(homePage.IsLogOffButtonExist, Is.True, "Log off button is not displayed");

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}