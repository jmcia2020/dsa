# Data Structure and Algorithms

## Reverse an Array

Write a function called `reverseArray` which takes an array as an argument.
Without utilizing any of the built-in methods available to your language,
return an array with elements in reversed order.

![White Board](../assets/ArrayReversed.png)

## Insert Shift Array

Without utilizing any of the built-in methods available in C#,
write a function called `insertShiftArray` which takes in an array
and the value to be added to the array.

Return an array with the new value added at the middle index.

![White Board](../assets/ArrayShift.jpg)

## Binary Sort

Search a sorted array for a Key using a Binary Sort.

![White Board](../assets/BinarySearch.JPEG)

## Singly Linked List

### Challenge
<!-- Description of the challenge -->

### Approach & Efficiency

<!-- What approach did you take? Why? 
What is the Big O space/time for this approach? -->

### API

Public Classes in Linked Lists.cs include:

| LinkedList | Node Head | Insert | Include| ToSring |

## Insertions

Write the following methods for the Linked List class:

`.append(value)` which adds a new node with the given value to the end of the list
`.insertBefore(value, newVal)` which add a new node with the given newValue immediately before the first value node
`.insertAfter(value, newVal)` which add a new node with the given newValue immediately after the first value node

![White Board](DsaAssets/LinkedList.Append.Insert.JPEG)

## PsuedoQueue

Create a brand new `PseudoQueue` class. Do not use an existing Queue. Instead, this `PseudoQueue` class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects.

`enqueue(value)` which inserts value into the PseudoQueue, using a first-in, first-out approach.
`dequeue()` which extracts a value from the PseudoQueue, using a first-in, first-out approach.

The Stack instances have only `push`, `pop`, and `peek` methods. 

You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

![PseudoQueue White Board](../DsaAssets/LinkedList.Append.Insert.JPEG)

## FIFO Animal Shelter

Create a class named `AnimalShelter` which takes in either dogs or cats using FIFO.

Use the methods `enqueue(animal)` to add a dog or a cat object

Use `dequeue(pref)` to return a dog or a cat. If none is in the stack return "null."

![FIFO White Board](../DsaAssets/FIFOAnimalShelterFull.JPEG)