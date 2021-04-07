
# Data Structures And Algorithms

## Linked Lists

### Challenge Description

`Append` - Insert a new node with a given value to the end of the linked list

`InsertBefore` - Insert a node with a given value before the first node with a specified value

`InsertAfter` - same as InsertBefore just after the specified value not before.

### Approach & Efficiency

`Append`(int value)

* Create newNode with value

* loop through the list until current.next is null then set current.next = newNode

`InsertBefore`(int beforeValue, int value)

* Create newNode with value

* Loop through list until current.next.value == beforeValue

* set newNode.next = current.next

* set current.next = newNode

`InsertAfter`(int afterValue, int value)-

* Create newNode with value

* loop through list until current.value == afterValue

* set newNode.next = current.next

* set current.next = newNode;

### Solution

### White Board

![LinkedList](DsaAssets/LinkedList.Append.Insert.JPG)

## Kth From The End

Write a method for the `Linked-List` class which takes a number, `k`, as a parameter. Return the node’s value that is `KthFromTheEnd` of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

### Challenge Description

<!-- Description of the challenge -->

### Approach & Efficiency

<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

### Solution

### White Board

![KFromTheEnd](DsaAssets/KFromEndOfList.jpeg)

## Class 11 Code Challenge

## Implement a Queue using two Stacks.

Create a brand new `PseudoQueue` class. Do not use an existing Queue. Instead, this `PseudoQueue` class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 `Stack` objects. Ensure that you create your class with the following methods:

`enqueue(value)` which inserts value into the PseudoQueue, using a first-in, first-out approach.

`dequeue()` which extracts a value from the PseudoQueue, using a first-in, first-out approach.

The `Stack` instances have only `push`, `pop`, and `peek` methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

## Example

`enqueue(value)`
Input-----------Args--Output
[10]->[15]->[20]--5---[5]->[10]->[15]->[20]
----[Empty Set]---5---[5]

`dequeue()`
Input-----------------Output---Internal State
[5]->[10]->[15]->[20]---20-----[5]->[10]->[15])
[5]->[10]->[15]---------15-----[5]->[10]

![LinkedList](DsaAssets/CodeChallenge11.JPG)

### Requirements

Ensure your complete solution follows the standard requirements.

Write unit tests.

