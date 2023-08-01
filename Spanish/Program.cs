using System;
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
            string driverPath = @"C:\Users\user\source\repos\Spanish\Spanish\bin\Debug\net6.0\New folder\Newfolder\chromedriver.exe";
            IWebDriver driver = new ChromeDriver(driverPath);


            try
            {
                // Step 1: Open the website
                driver.Navigate().GoToUrl("https://www.spanishpoint.ie/");


                // Wait for the cookie popup to appear (modify the time according to your needs)
                System.Threading.Thread.Sleep(5000); // Wait for 5 seconds (adjust as needed)

                // Find the "Reject" or "Decline" button and click it
                try
                {
                    IWebElement rejectButton = driver.FindElement(By.LinkText("Reject")); // Adjust the locator as needed
                    rejectButton.Click();
                }
                catch (NoSuchElementException)
                {
                    // If the reject button is not found, it means the cookie popup didn't appear, or the button has a different locator.
                    // Handle the case accordingly.
                }

                // Continue with the rest of the actions on the website
                // ...
            

                driver.Manage().Window.Maximize();

                System.Threading.Thread.Sleep(3000);

                // Step 2: Navigate to the 'Solutions & Services' section and select 'Modern Work'
                IWebElement solutionsServicesLink = driver.FindElement(By.LinkText("Solutions & Services"));
                solutionsServicesLink.Click();

                Thread.Sleep(3000);

                IWebElement modernWorkLink = driver.FindElement(By.LinkText("Modern Work"));
                modernWorkLink.Click();

                Thread.Sleep(3000);
                //driver.FindElement(By.XPath("//*[@id=\"wt-cli-reject-btn\"]")).Click();

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                System.Threading.Thread.Sleep(3000);

                js.ExecuteScript("window.scrollBy(0,250)");


                // Step 3: Click the 'Content & Collaboration' tab under the 'Modern Workplace Solutions' header
                //IWebElement contentCollaborationTab = driver.FindElement(By.XPath("//h2[text()='Modern Workplace Solutions']/following-sibling::ul//a[text()='Content & Collaboration']"));
                //contentCollaborationTab.Click();
                Thread.Sleep(5000); 
                IWebElement solutionsServicesLink1 = driver.FindElement(By.LinkText("Content & Collaboration"));
                solutionsServicesLink1.Click();

                // Step 4: Assert that there is a header with the text 'Content & Collaboration'
                //IWebElement headerElement = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/section/section/div[3]/div/div/div/div[2]/div/div[1]/ul/li[2]/a/span"));
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

                Thread.Sleep(3000);

                // Step 5: Assert that the displayed paragraph starts with the specified text
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
                driver.Quit();
            }
        }
    }
}
