using System;

namespace FindElementInRotatedArray_SinglePass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find an element in a rotated sorted array in Single Pass!");
            Console.WriteLine("---------------------------------------------------------");

            int[] array = ArrayUtility.GetArrayFromInput();
            Console.WriteLine("Enter the element to be searched in the array");
            try {
                int element = int.Parse(Console.ReadLine());
                ArrayUtility.FindElementInRotatedSortedArray(array, element);
            } catch (Exception exception){
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
