using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insertion Sort\n");
            Console.Write("*-----------------------------------------*\n");

            Console.Write("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int i;

            Console.Write("\nEnter elements in array :\n");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nBefore sorting: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            insertion_sort(arr);

            Console.Write("\nAfter sorting: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }

        //----------------------------------------------------------------------------------------------

        static int[] insertion_sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while ( j >= 0 && arr[j]>temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
