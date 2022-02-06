using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCShartNetCore
{
    public class Tests: DriverHelper
    {
        //public static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
           // Driver = new ChromeDriver();

            //Headless Browser
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            Driver = new ChromeDriver(option);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            //Type into a tetxtboxUnit Testing
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            
            //Checkbox
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            /*
            //Combo box
            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            //Click the typed value from the combo box
            Driver.FindElement(By.XPath("//div[@id = 'ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();
            */
            string comboControlName = "ContentPlaceHolder1_AllMealsCombo";
            //CustomControl control = new CustomControl();
            CustomControl.ComboBox(comboControlName, "Almond");

            Console.WriteLine("Test");
            Assert.Pass("Passed");
        }
    }
}