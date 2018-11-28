# Graph: Adjacency List

## Challenge

Create a custom Graph Adjacency Data Structure

## Instructions

Download the Graph solution and reference it as a dll to incorporate it into your project. 


## API

The Graph Data Structure consists of a Nested Linked List which contains a Tuple containing the Node and the Weight value.

This data structure contains four Methods and uses custom classes:

Node Class:

    Contains Two Properties:

       Value


Graph:

    AdjacencyList = LinkedList<LinkedList<Tuple<Node,int>>>

AddEdge(Node parent, Tuple<Node,int> child)

    Adds a new vertice to the graphs
    Include the ability to have a “weight”
    Bring in both the parent node, and the new node to be added

GetNodes()
    
    Returns all of the nodes in the graph as a collection

GetNeighbors()

    returns a collection of nodes connected to the given node
    Bring in a given node
    Include the weight from the given node.

Size()

    returns the total number of nodes in the graph




