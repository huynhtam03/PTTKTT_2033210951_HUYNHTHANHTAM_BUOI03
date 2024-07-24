using System;
using Cau01;
using Cau02;
using Cau03;

namespace PTTKTT_Buoi03_HuynhThanhTam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test hàm tính tổng mảng không đệ quy
            Console.WriteLine("Test SumArrayIterative:");
            int[] array = { 1, 2, 3, 4, 5 };
            int sumIterative = Sum_Array.SumArrayIterative(array, array.Length - 1);
            Console.WriteLine("Tong cua mang la: " +sumIterative);

            // Test hàm tính tổng mảng bằng đệ quy
            Console.WriteLine("\nTest SumArrayRecursive:");
            int sumRecursive = Sum_Array.SumArrayRecursive(array, array.Length - 1);
            Console.WriteLine("Tong cua mang la: " +sumRecursive);

            // Test hàm QuickSort
            Console.WriteLine("\nTest QuickSort:");
            int[] arrayToSort = { 3, 1, 4, 10, 5 };
            Console.WriteLine("Mang truoc khi sap xep:");
            PrintArray(arrayToSort);
            Quick_Sort.QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
            Console.WriteLine("Mang sau khi sap xep:");
            PrintArray(arrayToSort);

            // Test hàm Binary Search không đệ quy
            Console.WriteLine("\nTest Binary Search khong de quy:");
            int[] sortedArray = { 1, 2, 3, 4, 5, 6 };
            int target = 1;
            int resultIterative = Binary_Search.BinarySearchIterative(sortedArray, target);
            Console.WriteLine(resultIterative != -1 ? "Phan tu " + target + " duoc tim thay o chi so " + resultIterative + "." : "Phan tu " + target + " khong co trong mang.");

            // Test hàm Binary Search đệ quy
            Console.WriteLine("\nTest Binary Search de quy:");
            int resultRecursive = Binary_Search.BinarySearchRecursive(sortedArray, 0, sortedArray.Length - 1, target);
            Console.WriteLine(resultRecursive != -1 ? "Phan tu " + target + " duoc tim thay o chi so " + resultRecursive + "." : "Phan tu " + target + " khong co trong mang.");

            Console.ReadKey(); // Đợi người dùng nhấn bất kỳ phím nào

        }

        // Helper function to print array elements
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
