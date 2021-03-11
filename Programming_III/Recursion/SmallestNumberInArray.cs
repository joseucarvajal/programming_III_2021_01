using System;
namespace Programming_III.Recursion
{
    /*
    //Given an array (e.g.) [4, 7, 2, 11]. Get the smallest number into the array.
    //min = 2.

    //Recursive definition:
    //1. Base case
    //2. Solve problem partially
    //3. Make problem smaller

    //arr = [4, 7, 2, 11]
    //1. Base case:
    //  min(arr) = [3], min = 3, arr.length == 1 : arr[0]
    //  if(arr.length == 1) : arr[0]

    //ej
    //2. min([4, 7, 2, 11]) = 4 < 2 = 2
    //      min([7, 2, 11]) = 7 < 2 = 2
    //      min([2,11]) = 2 < 11 = 2
    //      min([11]) = 11 = 11

    n = arr.length, n = 4, i=0
    min(arr[0 ... n-1], i) = arr[i] < min([0 ... n-1], i+1)
    min([0 ... n-1], i) = arr[i] < min([2 ... n-1], i+1)
    min([0 ... n-1], i) = arr[i] < min([3 ... n-1], i+1)
    min([0 ... n-1], i) = arr[i] < min([4 ... n-1], i+1)

    Reemplazando...
    n = 4
    i = 0
    min([4, 7, 2, 11], 0) = 4 < min([4, 7, 2, 11], 1)
    min([4, 7, 2, 11], 1) = 7 < min([4, 7, 2, 11], 2)
    min([4, 7, 2, 11], 2) = 2 < min([4, 7, 2, 11], 3)
    min([4, 7, 2, 11], 3) = 11 (i == n - 1)
    
    */

    public class SmallestNumberInArray
    {
        public static void Main2(String[] args)
        {
            int[] arr = { 40, 70, 20, 11, 15, 81, 13, 9, 83  };
            int smallest = SmallestNumber(arr, 0);
            Console.WriteLine("The  smalles number is: " + smallest);

        }

        public static int SmallestNumber(int[] arr, int i)
        {
            if(i == arr.Length - 1) return arr[i];

            return Math.Min(arr[i], SmallestNumber(arr, i + 1));
        }
    }
}
