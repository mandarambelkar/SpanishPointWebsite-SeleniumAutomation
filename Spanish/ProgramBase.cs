/*using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram
{
    class Program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //Navigate to google page
            driver.Navigate().GoToUrl("https://www.spanishpoint.ie/solutions/modern-work/#1612870161121-10af43ab-0ec4");

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Find the Search text box using xpath
            IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));

            //Enter some text in search text box
            element.SendKeys("learn-automation");

            //Close the browser
           // driver.Close();
        }
    }
}
*/

internal class ProgramBase
{
}