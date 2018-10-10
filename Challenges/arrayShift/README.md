# ARRAY SHIFT

## Challenge

Given an array of N Size and an input number, the input number should be inserted into the middle of the array, thus increase the size of the array to N+1. If the array is an odd size, the input number should be on the right middle side of the array.

e.g.

With array [2,4,6,8] and input 5, the output should be	[2,4,5,6,8]

With array [4,8,15,23,42] and input 16, the output should be	[4,8,15,16,23,42]

## Approach and Reasoning

Assumptions: An array of zero length will simply output an array of 1 length with the input number occupying it:

{} + N => {N}

Due to type safety of C# (language of implementation), the array must be specified as an int array, and the number must be an int.

Time efficiency - Big O will be O(N) as the size of the operations will linearly increase corresponding the size of the array N

Space efficiency - Big O with be O(N) as a new array will be instantiated to process the input

## Solution

![Console](../../assets/arrayShift.jpg?raw=true "Output")