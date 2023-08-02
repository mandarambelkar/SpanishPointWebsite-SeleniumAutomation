# Selenium WebDriver Automation Solution

This repository contains a C# automation solution that uses Selenium WebDriver to perform the following tasks:

1. Visit the website "https://www.spanishpoint.ie/" using Google Chrome.
1. Expands 'Solutions & Services' and selects 'Modern Work'.
1. Clicks the 'Content & Collaboration' tab under the 'Modern Workplace Solutions' header.
1. Asserts that there is a header with the text 'Content & Collaboration' in the displayed panel.
1. Asserts that the displayed paragraph starts with the text 'Spanish Point customers tell us that people are their most important asset'.

## To use this automation solution, follow the steps below:

1. Prerequisites:
   - Ensure you have Google Chrome installed on your system.
    - Make sure you have .NET Framework 4.5 or higher installed.
 
1. Clone the Repository:
   - Clone this repository to your local machine using Git or download the ZIP file and extract it.

1. Set Up WebDriver:
   - This solution uses the WebDriverManager to automatically manage the ChromeDriver executable.
    - The WebDriverManager package will download the appropriate version of ChromeDriver for your system.
     - Ensure that you have the necessary NuGet packages, including WebDriverManager and Selenium WebDriver, installed in your project.

1. Build the Project:
   - Open the solution in Visual Studio or your preferred IDE.
    - Build the project to resolve any dependencies.

1. Run the Tests:
   - Open the 'Program.cs' file and execute the 'Main' method.
    - The automation script will open Google Chrome, navigate to the website, perform the required actions, and verify the assertions.
     - The script will output messages indicating whether the header and paragraph meet the specified conditions.

## Note
- The automation script may require updates in the future if the website's structure or content changes. You may need to adjust the locators and waiting times accordingly.
 - It's essential to handle potential exceptions or unexpected behavior during test execution, such as element not found or timeouts. In the current script, we have used simple try-catch blocks to handle the rejection/acceptance of cookies. A more robust exception handling approach can be implemented for a production-ready solution.
  - For a more maintainable and scalable automation solution, consider using Page Object Model (POM) design pattern to separate the page interactions from test logic.
    
Happy testing! If you have any questions or need further assistance, feel free to reach out.
