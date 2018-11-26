using System;
using System.Collections.Generic;
using System.Text;

namespace FindElementInRotatedArray_SinglePass
{
    static class ArrayUtility
    {
        public static int[] GetArrayFromInput() {
            Console.WriteLine("Enter the number of elements in the array");
            int[] array = null;
            try
            {
                int noOfElements = int.Parse(Console.ReadLine());
                array = new int[noOfElements];
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < noOfElements; i++) {
                    array[i] = int.Parse(elements[i]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return array;
        }

        public static void FindElementInRotatedSortedArray(int[] array, int element) {
            int index = 0;

            index = _FindElementInRotatedSortedArray(array, 0, array.Length-1, element);
            
            if(index == -1){
                Console.WriteLine("Element "+element+" is not present in the array!");
            }
            else {
                Console.WriteLine("Entered element "+element+" is present at index "+index);
            }
        }

        public static int _FindElementInRotatedSortedArray(int[] array, int start, int end, int element) {
            if (start <= end) {
                int middle = (start + end) / 2;
                if (middle < array.Length) {
                    if (array[middle] == element) {
                        return middle;
                    }
                    //The first sorted half
                    if (array[start] < array[middle])
                    {
                        //If element is less than middle, it should lie in first sorted half
                        if (element < array[middle]){
                            return _FindElementInRotatedSortedArray(array, start, middle - 1, element);
                        }
                        //If element is not less than the middle, it should lie in the second sorted half
                        return _FindElementInRotatedSortedArray(array, middle + 1, end, element);
                    }
                    //The sorted half lies in the second half
                    else {
                        //if middle is less than element, then it should lie in the first half
                        //This is because we see start element is already not less than middle
                        if (array[middle] < element) {
                            return _FindElementInRotatedSortedArray(array, start, middle-1, element);
                        }
                        return _FindElementInRotatedSortedArray(array, middle+1, end, element);
                    }
                }
                return -1;
            }
            return -1;
        }
    }
}
