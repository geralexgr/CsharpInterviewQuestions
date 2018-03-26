
# C# Interview Questions #

The project is a .NET Core application that includes code samples for some of the most frequently asked interview questions.




## Problems ##



* Given an array of `n` integers and a number `k` , perform `k` left rotations on the array. 
* Print multiplication table of size nxn.
* Find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum.
* Given n, complete the fibonacci function so it returns Fibonacci(n).
* Detect if a string is Palindrome.
* Insert an int item in a sorted linkedlist so that list remains sorted.
* Remove duplicate ints from a sorted linkedlist.


## Functions  ##


* `ArrayViewModel.LeftRotationByD`
* `ArrayViewModel.PrintMultiplicationTable`
* `ArrayViewModel.MaximumSumSubArray`
* `RecursionViewModel.Fibonacci`
* `StringViewModel.IsStringPalindrome`
* `LinkedListViewModel.InsertItemInSortedList`
* `LinkedListViewModel.RemoveDuplicatesFromSortedList`



## Code ##

* `var array = ArrayViewModel.LeftRotationByD(new int[] { 1, 2, 3, 4, 5 }, 1);`
* `PrintMultiplicationTable(10);`
* `var result = ArrayViewModel.MaximumSumSubArray(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 });`
* `var fib = RecursionViewModel.Fibonacci(3);`
* `var palindrome = StringViewModel.IsStringPalindrome("Savvas");`
* `var sorted = LinkedListViewModel.InsertItemInSortedList(linkedlist, new LinkedListNode<int>(0));`
* `var removed = LinkedListViewModel.RemoveDuplicatesFromSortedList(linkedlist);`
       



## Feedback ##

Please use [GitHub issues](https://github.com/jerrak0s/CsharpInterviewQuestions/issues) for bug reports and feature requests