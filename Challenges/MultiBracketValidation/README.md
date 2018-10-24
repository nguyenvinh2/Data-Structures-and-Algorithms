# Multi Bracket Validation

## Challenge

Evaluate an input string to see whether the brackets (curly: {}, parenthesis: (), and square: []) located within the string is balanced. An opening bracket should have a closing bracket. The brackets cannot be mismatched, i.e. { cannot be closed with ). The method should return a boolean value, true or false, depending on whether or not the brackets are balanced.

For example,

{} is	TRUE
{}(){}	is TRUE
()[[Extra Characters]]	is TRUE
(){}[[]]	TRUE
{}{Code}[Fellows](()) is	TRUE
[({}]	is FALSE
(](	is FALSE
{(})	is FALSE

## Approach and Reasoning

This challenge will make use of the Queue Data Structure.

[Stacks and Queue](../../Data%20Structures/StacksAndQueue/)

Time and Space Efficiency will be O(N) due to creation of character array to hold string input.

No null inputs. Empty Strings Okay.

No brackets and empty string will evaluate to TRUE as their brackets are technically balanced.

## Solution

![Console](../../assets/multi_bracket_validation.jpg?raw=true "Output")
