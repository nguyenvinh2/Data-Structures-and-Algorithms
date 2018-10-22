# QUEUE WITH STACKS

## Challenge

Given a Linked Lists, reverse the order of the LL, where the head Node becomes and the End Node and the End Node becomes the Head Node.

If the input LinkList is [1] -> [2] -> [3] -> [4] -> [5] 

then the result should be:

[5] -> [4] -> [3] -> [2] -> [1]

## Approach and Reasoning

Assumptions:

The Link List Challenge is based on an existing class on C# consisting of a Node Class
contain the properties of the Data and Pointer to the next node.
The Link List Class should be aware of the Head Node and the Current Node.

[Linked List](../../Data%20Structures/LinkedList/)

A Null input will simply return null.

## Solution

Create 2 Temp Nodes

Set TempNodePrevious = null

Set TempNodeNext;

Set Current Node = Head

Create While loop. Run while Current != Null

Within While loop:

  Set TempNodeNext = Current.Next
  
  Set Current.Next = Previous
  
  Set Previous = Current
  
  Set Current = TempNodeNext

This sequence will repeat until end of Link List

Output:

![Console](../../assets/queue_with_stacks.jpg?raw=true "Output")
