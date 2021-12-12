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
            //driver = new ChromeDriver("C:\\Driver");
        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            CustomControls.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");
            CustomControls.Click(driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")));
            CustomControls.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");


        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}