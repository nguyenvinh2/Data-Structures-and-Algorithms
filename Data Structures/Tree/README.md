# Tree

## Challenge

Create a Custom Tree Node Data Structure that can traverse in PreOrder, InOrder, PostOrder.
Also create a custom Binary Search Tree that can add integer values and return the a node that contains the search value.

The PreOrder Traversal is structured via the following: 

![Console](../../assets/preorder.png?raw=true "Output")

The InOrder Traversal is structured via the following: 

![Console](../../assets/inorder.png?raw=true "Output")

The PostOrder Traversal is structured via the following: 

![Console](../../assets/postorder.png?raw=true "Output")

The BST contains a root node with an integer of some value. 

Values that are less than the base node will be added to the left.

Values that are greater than the base node will be added to the right.

## Instructions

Download the Tree solution and reference it as a dll to incorporate it into your project. 

Contains 3 classes:

The Node class for trees which contains Data, Left, and Right properties.

The Binary Tree Classes, which allows for the aforementioned traversal methods

The BST Class, which adds and searches for values based on the binary principle.

## API

Add(Node node) - adds a node to the BST structure based on the value of the node

Search(int value) - returns the node that contains the integer value

PreOrder(Node Root) - returns a list of int values based on preorder sort

PostOrder(Node Root) - returns a list of int values based on inorder sort

Dequeue(Node Root) - returns a list of int values based on postorder sort