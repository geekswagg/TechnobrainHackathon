using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium;

class Program
{
    static void Main()
    {
        TestIntegersList();
        TestQuestionTwo();
        TestQuestionFour();
        TestQuestionFive();
        TestQuestionSix();
    }

    static void TestIntegersList()
    {
        // Read a list of integers from the console
        Console.WriteLine("Enter numbers separated by space:");
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        // Remove duplicates using a HashSet and then convert back to a list
        var uniqueNumbers = new HashSet<int>(numbers).ToList();

        // Sort the list in descending order
        uniqueNumbers.Sort((a, b) => b.CompareTo(a));

        // Print the sorted list
        Console.WriteLine("Sorted list in descending order without duplicates:");
        uniqueNumbers.ForEach(Console.WriteLine);
    }

    static void TestQuestionTwo()
    {
        // Initialize the WebDriver (e.g., using Chrome)
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the Login page
            driver.Navigate().GoToUrl("https://app.hewani.co.ke");

            // Enter username
            IWebElement usernameField = driver.FindElement(By.Id("loginForm_email"));
            usernameField.SendKeys("admin@virtualcity.co.ke");

            // Enter password
            IWebElement passwordField = driver.FindElement(By.Id("loginForm_password"));
            passwordField.SendKeys("password");

            // Click the login button
            IWebElement loginButton = driver.FindElement(By.ClassName("ant-btn-primary"));
            loginButton.Click();

            // Wait for the home page to load
            Thread.Sleep(5000); // Adjust this sleep time based on your page load time

            // Verify that the user is redirected to the home page
            if (!driver.Title.Contains("Hewani Aggregate"))
            {
                throw new Exception("Login failed or user was not redirected to the home page.");
            }

            // Verify that the welcome message is displayed
            IWebElement welcomeMessage = driver.FindElement(By.Id("welcomeMessage"));
            if (!welcomeMessage.Text.Contains("Welcome"))
            {
                throw new Exception("Welcome message not found.");
            }

            Console.WriteLine("Login test passed.");
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }

    static void TestQuestionFour()
    {
        // Initialize the WebDriver (e.g., using Chrome)
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Open a browser and navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the search box, enter the term "Test automation" and submit
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Test automation");
            searchBox.SendKeys(Keys.Enter);

            // Wait for the results page to load
            Thread.Sleep(2000); // Adjust this sleep time based on your page load time

            // Verify that the search results page contains results
            var results = driver.FindElements(By.CssSelector("div.g"));
            if (results.Count > 0)
            {
                Console.WriteLine("Test passed: Search results found.");
            }
            else
            {
                Console.WriteLine("Test failed: No search results found.");
            }
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }

    static void TestQuestionFive()
    {

    }

    static void TestQuestionSix()
    {
        // Desired capabilities for the Appium server to interact with the mobile app
        AppiumOptions options = new AppiumOptions();
        options.AddAdditionalCapability("platformName", "Android");
        options.AddAdditionalCapability("deviceName", "Android Emulator");
        options.AddAdditionalCapability("appPackage", "com.example.yourapp");  // Replace with your app's package name
        options.AddAdditionalCapability("appActivity", "com.example.yourapp.MainActivity");  // Replace with your app's main activity
        options.AddAdditionalCapability("automationName", "UiAutomator2");

        // Initialize the Appium driver
        AndroidDriver<IWebElement> driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);

        try
        {
            // Launches the application (implicit with the initialization)

            // Log in using predefined username and password
            IWebElement usernameField = driver.FindElementById("com.example.yourapp:id/username");
            IWebElement passwordField = driver.FindElementById("com.example.yourapp:id/password");
            IWebElement loginButton = driver.FindElementById("com.example.yourapp:id/loginButton");

            usernameField.SendKeys("your_username");
            passwordField.SendKeys("your_password");
            loginButton.Click();

            Thread.Sleep(2000);  // Wait for the next screen to load

            // Navigate to the Profile screen
            IWebElement profileButton = driver.FindElementById("com.example.yourapp:id/profileButton");
            profileButton.Click();

            Thread.Sleep(2000);  // Wait for the profile screen to load

            // Update profile information
            IWebElement nameField = driver.FindElementById("com.example.yourapp:id/name");
            nameField.Clear();
            nameField.SendKeys("New Name");

            IWebElement saveButton = driver.FindElementById("com.example.yourapp:id/saveButton");
            saveButton.Click();

            Thread.Sleep(2000);  // Wait for the save action to complete

            // Verify that the profile was updated
            string updatedName = nameField.GetAttribute("text");
            if (updatedName != "New Name")
            {
                throw new Exception("Profile update failed!");
            }

            Console.WriteLine("Test passed: Profile updated successfully.");
        }
        finally
        {
            // Close the app
            driver.Quit();
        }
    }
}
