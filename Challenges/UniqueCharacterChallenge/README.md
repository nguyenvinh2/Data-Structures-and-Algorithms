# Unique Character Challenge

## Challenge

Determine if a string is full of unique characters.

That is, 

    Input	                                          Output

    The quick brown fox jumps over the lazy dog	  FALSE

    I love cats	                                   TRUE

    Donald the duck	                              FALSE

## Approach and Reasoning

Assumptions:

A Hashtable is used in the solution. It can be found in:

[Hashtables](../../Data%20Structures/Hashtables/)

A Null input will return true as it technically has not repeating charactres.

## Solution

    A Hashmap is used to store each character in the string. 
    The string is iterateed through and each of the characters
    is stored in the Hashset. Ff the value already exists, 
    return false as soon as a duplicate occurs. If the string
    is fullied iterated through without return false, return true.

Uses O(N) space and time.
