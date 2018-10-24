# FIFO Animal Shelter

## Challenge

Create an "Animal Shelter" Class that accepts "Dogs" and "Cats" and utilizises the First In First Out data structure. When a dog is requested to be "released" the Shelter should return the first Dog added to the shelter. The remaining animals should still be in the order it was added in. When an animal other than a dog or cat is requested to be removed, it should return the first animal in the shelter.

If the Shelter has ->[Dog: Spotty|Cat: Mittens|Dog: Spike|Cat: Mew|Cat:Bulby]-> and a Dog is requested, 

then the result should be:

->[Dog: Spotty|Cat: Mitten|Cat: Mew|Cat:Bulby]-> with Spike being returned.

## Approach and Reasoning

This challenge will make use of the Queue Data Structure.

[Stacks and Queue](../../Data%20Structures/StacksAndQueue/)

The solution will have O(N) time efficiency and O(1) space efficiency.

The code implementation will differ from the whiteboard algorithm in that one Queue will be the designated "Shelter", always holding the animals sent to the shelter. The second Queue will be used for temporary operations during the Dequeing process. The Second Queue is not necessarily required to complete the challenge but will be implemented here.

A Marker will be added to the Queue, differing from the Whiteboard solution.

A Null input will have no effect.

## Solution

Output:

![Console](../../assets/fifo_animal_shelter.jpg?raw=true "Output")
