Author: Giruba Beulah SE

# SearchInSortedRotatedArraySinglePass
C# program to find an element in a sorted array that is rotated

Logic
-----
 There are two cases where the rotated array can be present
   a. The rotated array has the rotation point in the middle meaning, the array is split into two sorted halves evenly
   b. The sorted halves are not even

1. If start <= end, calculate middle as (start+end)/2 and check if middle is less than array length
   1.1  If array[middle] == entered element to search, return the middle as the index of element's position in the array
   1.2  If array[start] < array[middle], then there is a sorted half on the front
        1.2.1  If array[middle] > element,  then the element should lie between start and middle, hence, call the function recursively
               with start = start but end as middle-1
        1.2.2 If array[middle] is not greater than element, then element should lie after the first sorted half.
               Call the function recursively where start = middle+1 and end as end
   1.3 If array[start] is not less than middle, the sorted halves are not even after rotation
       1.3.1 If array[middle] < element, the function should be called with start = start and end as middle-1.
             This is becuase, the element is greater than middle element and the start element is also greater than middle element
             Therefore, the element shoud lie before the middle element
       1.3.2 If array[middle] is not less than the element, then the element should lie in the second half which is sorted
             The function should be called with start = middle+1 and end = end
2. If start is not less than or equal to end return -1

