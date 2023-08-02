//imported necessary namespaces for Selenium WebDriver and Chrome WebDriver.using System;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Support.UI;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the path to the ChromeDriver
            new DriverManager().SetUpDriver(new ChromeConfig());

            // Set Chromedriver path
            string drivePath = @". chromedriver.exe";
            IWebDriver driver = new ChromeDriver(drivePath);


            try
            {
                // Step 1: Open the website
                driver.Navigate().GoToUrl("https://www.spanishpoint.ie/");


                // Wait for the cookie popup to appear 
                System.Threading.Thread.Sleep(3000); // Wait for 3 seconds (adjust as needed)

                // Find the "Reject" or "Decline" button and click it if present
                try
                {
                    IWebElement rejectButton = driver.FindElement(By.LinkText("Reject")); // Adjust the locator
                    rejectButton.Click();
                }
                catch (NoSuchElementException)
                {
                    // If the reject button is not found, it means the cookie popup didn't appear, or the button has a different locator.
                    // Handle the case accordingly.
                }

                // Continue...

                //maximize the browser window(optional)
                driver.Manage().Window.Maximize(); 

                System.Threading.Thread.Sleep(3000);

                // Step 2: Navigate to the 'Solutions & Services' section and select 'Modern Work'
                IWebElement solutionsServicesLink = driver.FindElement(By.LinkText("Solutions & Services")); //findind element using LinkText
                solutionsServicesLink.Click();

                System.Threading.Thread.Sleep(3000);

                IWebElement modernWorkLink = driver.FindElement(By.LinkText("Modern Work"));
                modernWorkLink.Click();

                System.Threading.Thread.Sleep(3000);

                // Scrolling down webpage
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                System.Threading.Thread.Sleep(3000);

                js.ExecuteScript("window.scrollBy(0,500)");


                // Step 3: Click the 'Content & Collaboration' tab under the 'Modern Workplace Solutions' header
                System.Threading.Thread.Sleep(3000);
                IWebElement solutionsServicesLink1 = driver.FindElement(By.LinkText("Content & Collaboration"));
                solutionsServicesLink1.Click();

                // Step 4: Assert that there is a header with the text 'Content & Collaboration'
                
                IWebElement headerElement = driver.FindElement(By.LinkText("Content & Collaboration"));

                string headerText = headerElement.Text;
                if (headerText.Contains("Content & Collaboration"))
                {
                    Console.WriteLine("Header with text 'Content & Collaboration' is displayed.");
                }
                else
                {
                    Console.WriteLine("Header with text 'Content & Collaboration' is NOT displayed.");
                }

                System.Threading.Thread.Sleep(3000);

                // Step 5: Assert that the displayed paragraph starts with the specified text
                //findind element by XPath
                
                IWebElement paragraphElement = driver.FindElement(By.XPath("//*[@id=\"1612870161121-10af43ab-0ec4\"]/div[2]/div/div[2]/div/div/div[1]/div/p"));
                string paragraphText = paragraphElement.Text;
                string expectedStartText = "Spanish Point customers tell us that people are their most important asset";
                if (paragraphText.StartsWith(expectedStartText))
                {
                    Console.WriteLine("Paragraph starts with the expected text.");
                }
                else
                {
                    Console.WriteLine("Paragraph does NOT start with the expected text.");
                }
            }
            finally
            {
                driver.Quit(); // Close the browser and quit the WebDriver
            }
        }
    }
}
