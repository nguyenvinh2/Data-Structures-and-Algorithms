# Merge Sort

## Challenge

Using the Merge Sort Algorithm, create a method that takes in an unsorted int array and returns a sorted array.

## Algorithm

The algorithm recursively splits the input array into two subarrays until it is unable to split the array further. It then sorts out the index order prior to merging them back into the original array size.

## Instructions

Download the InsertionSortAlgorithm solution. Run the Program or reference it as a dll to incorporate it into your project. 


## API

The unsorted array can be of varied size.

This data structure lies in the Program.cs class and only has one method.

    MergeSort(int[] input):

    Recursively splits the array into two subarrays and calls on the Merge method to reorder the indices.

    Merge(int[] leftArray, int[] rightArray):

    Does the comparison and reorders according to int value.