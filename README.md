# This is the implementation of the Technobrain Hackathon

## Q1 - Explanation.

1. Reading Input: Both programs start by reading a list of integers from the console, where the user inputs numbers separated by spaces.
2. Removing Duplicates: Duplicates are removed by converting the list to a set (which inherently removes duplicates).
3. Sorting: The list is then sorted in descending order.
4. Printing: Finally, the sorted list is printed to the console.

## Q2 - Explanation.

1. Navigating to the Login Page: The get() method in Python and Navigate().GoToUrl() in C# are used to navigate to the specified URL.
2. Entering Username and Password: The find_element() method in Python and FindElement() in C# are used to locate the username and password fields by their ID. The send_keys() method is then used to enter the text.
3. Clicking the Login Button: The click() method simulates a click action on the login button.
4. Verification: After the login action, the script checks if the title of the page contains "Home" to ensure the user has been redirected. It then checks if a welcome message is displayed by finding the element and verifying its text.
5. Browser Cleanup: The browser is closed using quit() in both Python and C#.
These scripts assume the IDs for the elements (username, password, loginButton, welcomeMessage) are correct and that the home page title contains "Home".

## Q3 - SQL Scripts

1. Retrieve All Users Who Registered in the Last 30 Days - This query selects all columns from the Users table where the CreatedDate is within the last 30 days. The DATEADD function subtracts 30 days from the current date, which is retrieved using GETDATE().

2. Find the Total Number of Users with a Specific Domain in the Email (e.g., '@example.com') - This query counts the number of users in the Users table whose Email ends with @example.com. The LIKE operator is used with the % wildcard to match any string before the @example.com domain.

3. Update the Email of a User with a Specific 'UserId' - This query updates the Email field for the user with a UserId of 12345. Replace 12345 with the specific UserId and newemail@example.com with the new email address you want to set.

## Q6 - Test Framewotk Design
Framework structure

TestAutomationFramework/
│
├───Config/
│   └───Config.cs                # Configuration file for global settings
│
├───Data/
│   └───TestData.json            # Test data management files
│
├───Pages/
│   ├───BasePage.cs              # Base page with common methods
│   ├───LoginPage.cs             # Page object for the login page
│   └───HomePage.cs              # Page object for the home page
│
├───Tests/
│   └───LoginTests.cs            # Test case for login functionality
│
├───Reports/
│   └───TestReport.html          # Test report output files
│
├───Utilities/
│   ├───Logger.cs                # Custom logger utility
│   ├───WebDriverManager.cs      # WebDriver management (setup/teardown)
│   └───Reporting.cs             # Reporting utility
│
└───packages.config              # Project dependencies
