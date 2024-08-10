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

