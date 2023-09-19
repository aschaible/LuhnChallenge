## Luhn Challenge

The Luhn algorithm, also known as the "modulus 10" or "mod 10" algorithm, is a simple checksum formula used to validate a variety of identification numbers, including credit card numbers. It's widely used in the financial industry to detect errors in credit card numbers and prevent fraudulent transactions.

The algorithm works by verifying that the sum of certain digits in the number, when processed according to a specific set of rules, is divisible by 10. If the sum is divisible by 10, the number is considered valid; otherwise, it is invalid.

## Here's how the Luhn algorithm works:

1.  Starting from the rightmost digit (the check digit) and moving left, double the value of every second digit. If doubling a digit results in a number greater than 9, subtract 9 from the product.
2.  Sum all the digits in the number, both those that were doubled and those that were not.
3.  If the total sum is divisible by 10 (i.e., the remainder of the division by 10 is 0), then the credit card number is valid. Otherwise, it's invalid.

Your task is to implement a program that can validate credit card numbers using the Luhn algorithm. Specifically, you need to:

1.  Accept a credit card number as input from the user.
2.  Implement the Luhn algorithm to validate the credit card number.
3.  Output whether the credit card number is valid or invalid based on the Luhn algorithm's result.

## Constraints:

1.  The input credit card number will be a string of digits (0-9) with no spaces or special characters.
2.  The credit card number should have a minimum length of 13 digits and a maximum length of 19 digits.
3.  You must implement the Luhn algorithm to validate the credit card number.
