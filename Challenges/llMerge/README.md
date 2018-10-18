# Link List Merge

## Challenge

Given an input of two Linked Lists, each with some number of nodes, return a merged Linked Lists where the sequence of nodes will alternate pointing to each of the Two Input LL Nodes is sequence.
e.g.

If LinkList One is [1] -> [2] -> [3] -> [4] -> [5] 
and LinkList Two is [A] ->[B] -> [C] -> [D],

then the result should be:

[1] -> [A] -> [2] -> [B] -> [3] -> [C] ->[4] -> [D] -> [5]

## Approach and Reasoning

Assumptions:

The Link List Challenge is based on an existing class on C# consisting of a Node Class
contain the properties of the Data and Pointer to the next node.
The Link List Class should be aware of the Head Node and the Current Node.

[Linked List](../../Data%20Structures/LinkedList/)

## Solution

The Algorith Shown below was found to be a little too complicated and convoluted to be implement in real code using C#:

![Console](../../assets/ll_merge.jpg?raw=true "Output")

Instead a new algorithm was utilized.

First, it accounts for Link List inputs will null nodes.
If One Link List is null, then the result will simply be the other LL
If both are null, the result will be null as well.

If both LL contains Nodes with values, then a while loop is run as long as BOTH LL contains valid Nodes.

Prior to running the while loop, the Head of the Result Link List is set equal to the head of LL One. 

The Current of the Result LL is then set equal to the Result Head. The same is done for LL One and LL Two.

Within the while loop, two Temp Nodes (for One and Two) are created, each equaling to the Next property of the Current Node of LL One and Two.

The Next property of the Current Node of LL One (and thus the Current of the Result as well as they are equal) is set equal to Current Node of LL Two.

The Next property of Current Node for LL Two is then pointed to Temp One (which is equal to the Next property of the Current Node for LL One)

In this way, they alternate between Nodes for LL One and LL Two.

Move the Current Nodes for LL One and Two to the Next Node.

Repeat until nodes run out.
