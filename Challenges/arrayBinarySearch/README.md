# ARRAY BINARY SEARCH

## Challenge

Given a sorted array of N Size and an input number, find the location of the input number in the array and return its index position. If not found, the output will return -1.

e.g.

With array [2,4,5,8] and input 4, the output should be 1

With array [4,8,15,23,42] and input 42, the output should be 4

With array [4,8,15,23,42] and input 76, the output should be -1

## Approach and Reasoning

Assumptions: The array must be sorted from lowest values to highest. It will not work otherwise. 
e.g.

[3,5,3,3,3] is not guaranteed to return a correct index. 

{} + N => {N}

Due to type safety of C# (language of implementation), the array must be specified as an int array, and the number must be an int.

Time efficiency - Big O will be O(log2(N)). Characteristic of a binary search due to the array search size being cut in half with every loop of search operations.

Space efficiency - Big O with be O(1) as no new array of variable size will be instantiated to process the input

## Solution

![Console](../../assets/arrayBinarySearch.jpg?raw=true "Output")