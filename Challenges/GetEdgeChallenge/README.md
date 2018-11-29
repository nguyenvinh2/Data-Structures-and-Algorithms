# Get Edge Direct Flights for Itinerary Challenge

## Challenge

Given a business trip itinerary, and an Alaska Airlines route map, is the trip possible with direct flights? If so, how much will the total trip cost be?

Create a method based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.

![Console](../../assets/city_graph.PNG?raw=true "Output")
![Console](../../assets/city_inputoutput.PNG?raw=true "Output")

## Approach and Reasoning

The solution utilizes a custom made Graph Adjacency List to store all of the cities

For each city in the array, the method traverses through its neighbor collections and sees if it contains the next indices in the itinerary array.

[Graphs](../../Data%20Structures/Graph/)

## Solution

![Console](../../assets/get_edge.jpg?raw=true "Output")
