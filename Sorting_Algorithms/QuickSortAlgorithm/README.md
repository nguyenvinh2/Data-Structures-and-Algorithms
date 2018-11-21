# Quick Sort

## Challenge

Using the Quick Sort Algorithm, create a method that takes in an unsorted int array and returns a sorted array.

## Algorithm

Uses recursion.

Takes in 3 parameters: Array, Left Index, Right Index of Array.

Start with a Pivot point (to equal Left Index)

Iterates through array, reorder array so that values < pivot comes before it and values > pivot comes after it.

The pivot now partitions the array into two sub-arrays, those to the left and to the right of the pivot.

Recursively apply the above steps to the sub-array of elements with smaller values and separately to the sub-array of elements with greater values.

## Instructions

Download the QuickSortAlgorithm solution. Run the Program or reference it as a dll to incorporate it into your project. 


## API

The unsorted array can be of varied size.

This data structure lies in the Program.cs class and only has one method.

    QuickSort(int[] input, int left, int right):

    Takes in any int array and returns an array with the values in the input array sorted.

    Partition(int[] input, int left, int right):

    Private Method. Does the actual partitioning.