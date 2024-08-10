using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace interview
{
    public class SeleniumOne
    {
        static void TestQuestionTwo()
        {
            // Initialize the WebDriver (e.g., using Chrome)
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Navigate to the Login page
                driver.Navigate().GoToUrl("https://example.com/login");

                // Enter username
                IWebElement usernameField = driver.FindElement(By.Id("username"));
                usernameField.SendKeys("your_username");

                // Enter password
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("your_password");

                // Click the login button
                IWebElement loginButton = driver.FindElement(By.Id("loginButton"));
                loginButton.Click();

                // Wait for the home page to load
                Thread.Sleep(5000); // Adjust this sleep time based on your page load time

                // Verify that the user is redirected to the home page
                if (!driver.Title.Contains("Home"))
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
    }



}


