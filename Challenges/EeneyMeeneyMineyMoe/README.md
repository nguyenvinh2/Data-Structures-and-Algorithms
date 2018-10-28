# Link List Reverse

## Challenge

### Context
People are standing in a circle playing Eeney Meeney Miney Moe. Counting begins at a specified point in the circle and proceeds around the circle in a specified direction. After a specified number of people are skipped, the next person is removed. The procedure is repeated with the remaining people, starting with the next person, going in the same direction and skipping the same number of people, until only one person remains, and wins the game.

### Task

Write a method that takes in a input number N and a list of names (in string). Emulate the given context above and return the remaining name last in the list.

### Example

n=3
[A, B, C, D, E]    // 1A, 2B, 3C
[A, B, _, D, E]    // C was removed
[_, B, _, D, E]    // A was removed
[_, B, _, D, _]    // E was removed
[_, _, _, D, _]    // B was removed
                   // only D is left

## Approach and Reasoning

Assumptions:

Will use a Queue to solve this challenge.

Method will continue to dequeue the Front name and enqeue to the back of list (while counting up in sequence) until the count is equal to the input number. Then it dequeues that particular name.

This will repeat until there is only one name left on the list.

Time efficiency will be O(n)

Because this method has to convert a list to a queue, space efficiency will also by O(n)

[Stack and Queue](../../Data%20Structures/StackAndQueue/)

A Null input will simply return null node

## Solution


![Console](../../assets/eeney_meeney.PNG?raw=true "Output")
