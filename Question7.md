# Test Scenario: Add Items to Cart and Proceed to Checkout

These test cases cover various scenarios for adding items to a cart and proceeding to checkout in a web-based e-commerce application. The positive test cases ensure that the main functionalities work as expected, while the negative test cases focus on validating how the application handles edge cases, errors, and invalid inputs. This approach ensures a comprehensive assessment of the application's reliability and user experience.

## Positive Test Cases

### Test Case 1: Add Single Item to Cart and Proceed to Checkout

Precondition: User is logged in and on the product listing page.
Steps:
Select a product and click on "Add to Cart."
Navigate to the cart.
Verify the item is in the cart with the correct quantity and price.
Click on "Proceed to Checkout."
Verify the user is taken to the checkout page.
Expected Result: The item is successfully added to the cart, and the user is redirected to the checkout page.

### Test Case 2: Add Multiple Items to Cart and Proceed to Checkout

Precondition: User is logged in and on the product listing page.
Steps:
Select multiple products and click on "Add to Cart" for each.
Navigate to the cart.
Verify that all selected items are in the cart with the correct quantities and prices.
Click on "Proceed to Checkout."
Verify the user is taken to the checkout page.
Expected Result: All items are added to the cart correctly, and the user is redirected to the checkout page.

### Test Case 3: Update Quantity of an Item in the Cart

Precondition: User has at least one item in the cart.
Steps:
Navigate to the cart.
Increase the quantity of an item.
Verify that the cart updates the quantity and total price accordingly.
Expected Result: The quantity and total price are updated correctly.

### Test Case 4: Remove an Item from the Cart

Precondition: User has at least one item in the cart.
Steps:
Navigate to the cart.
Click the "Remove" button next to an item.
Verify that the item is removed from the cart.
Expected Result: The item is removed from the cart, and the cart total is updated correctly.

### Test Case 5: Proceed to Checkout with Valid Payment Information

Precondition: User has items in the cart and is on the checkout page.
Steps:
Fill in valid shipping details.
Select a payment method and enter valid payment information.
Click on "Place Order."
Verify that the order is successfully placed, and a confirmation message is displayed.
Expected Result: The order is placed successfully, and a confirmation message is shown.

## Negative Test Cases

### Test Case 6: Add Item to Cart with No Stock Available

Precondition: A product is marked as "Out of Stock."
Steps:
Attempt to add the out-of-stock product to the cart.
Expected Result: The user should receive an error message stating that the item is out of stock, and it should not be added to the cart.

### Test Case 7: Proceed to Checkout with Empty Cart

Precondition: User has an empty cart.
Steps:
Attempt to click on "Proceed to Checkout" with no items in the cart.
Expected Result: The user should receive a message that the cart is empty and should not be able to proceed to checkout.

### Test Case 8: Attempt to Proceed to Checkout with Invalid Payment Information

Precondition: User has items in the cart and is on the checkout page.
Steps:
Enter invalid payment information (e.g., incorrect credit card number).
Click on "Place Order."
Expected Result: The user should receive an error message indicating that the payment information is invalid and should not be able to complete the purchase.

### Test Case 9: Attempt to Place Order with Incomplete Shipping Details

Precondition: User has items in the cart and is on the checkout page.
Steps:
Leave required fields (e.g., address, postal code) empty in the shipping details.
Click on "Place Order."
Expected Result: The user should receive an error message indicating that all required fields must be completed before placing an order.

### Test Case 10: Remove Item from Cart and Check Cart Total

Precondition: User has multiple items in the cart.
Steps:
Remove one item from the cart.
Verify that the cart total is updated correctly, excluding the removed item.
Expected Result: The item is removed from the cart, and the total is recalculated correctly.

### Test Case 11: Add Same Item Multiple Times and Verify Cart Behavior

Precondition: User is logged in and on the product listing page.
Steps:
Add the same product to the cart multiple times.
Verify whether the cart adds the product as separate items or increases the quantity of the product.
Expected Result: The cart should either increase the quantity of the product or list the product separately based on the application's design.
