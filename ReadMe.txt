Code question.
Please look to attached images for the code question details.
This solution is raw, and not final at all.

Thank you
Sam Klok

=======================================================
Code Question
At Amazon's annual sale, employees are tasked with generating valid discount coupons for loyal customers. 
However, there are some used/invalid coupons in the mix, and the challenge in this task is to determine 
whether a given discount coupon is valid or not. 

The validity of a discount coupon is determined as follows: 

1. An empty discount coupon is valid. 
2. If a discount coupon A is valid, then a discount coupon C made by adding one character xto both the beginning of A 
and the end of A is also valid (i.e the discount coupon C = xAx is valid). 
3. If two discount coupons A and Bare valid, then the concatenation of B and A is also valid 
(i.e the coupons AB and BA are both valid). 

Given n discount coupons, each coupon consisting of only lowercase English characters, 
where the i-th discount coupon is denoted discounts[i], determine if each discount coupon is valid or not. 
A valid coupon is denoted by 1 in the answer array while an invalid coupon is denoted by 0. 

Example 
discounts = ['tabba'; 'abca']

Check if this coupon code can be constructed within the rules of a valid coupon. 
Checking 'abba': 
• The empty string is valid per the first rule. 
• Under the second rule, the same character can be added to the beginning and end of a valid coupon code. 
  Add 'b' to the beginning and end of the empty string to have 'bb', a valid code. 
• Using the same rule, 'a' is added to the beginning and end of the 'bb' coupon string. Again, the string is valid. 

The string is valid, so the answer array is [1]. 

Checking 'abca': 
• Using rule 2, a letter can be added to both ends of a string without altering its validity. 
  The 'a' added to the beginning and end of 'bc' does not change its validity. 
• The remaining string 'Ix', is not valid. There is no rule allowing the addition of different characters to the ends of a string.

Since the string is invalid, append 0 to the answer array. There are no more strings to test, so return [1,0]

Function Description 

Complete the function find ValidDiscountCoupons in the editor below. 

find ValidDiscountCoupons has the following parameter: 
string discounts[n]: the discount coupons to validate 

Returns 
int[n]: each element i is 1 if the coupon discounts[il is valid and 0 otherwise 


https://stackoverflow.com/questions/70319982/validate-string-coupons-which-could-be-combo-of-other-valid-coupons
