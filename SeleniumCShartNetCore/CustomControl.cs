using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCShartNetCore
{
    public class CustomControl: DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            
            comboControl.Clear();
            comboControl.SendKeys(value);
            //Click the typed value from the combo box
            Driver.FindElement(By.XPath($"//div[@id = '{controlName}-dropmenu']//li[text()='{value}']")).Click();

        }
    }
}
