using System;

namespace Cau03
{
    public class Binary_Search
    {
        // Hàm Binary Search không đệ quy
        public static int BinarySearchIterative(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Tính chỉ số giữa

                if (array[mid] == target) // Tìm thấy phần tử
                    return mid;
                else if (array[mid] > target) // Phần tử ở nửa bên trái
                    right = mid - 1;
                else // Phần tử ở nửa bên phải
                    left = mid + 1;
            }

            // Nếu không tìm thấy phần tử
            return -1;
        }
        // Hàm Binary Search đệ quy
        public static int BinarySearchRecursive(int[] array, int left, int right, int target)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2; // Tính chỉ số giữa

                if (array[mid] == target) // Tìm thấy phần tử
                    return mid;
                else if (array[mid] > target) // Phần tử ở nửa bên trái
                    return BinarySearchRecursive(array, left, mid - 1, target);
                else // Phần tử ở nửa bên phải
                    return BinarySearchRecursive(array, mid + 1, right, target);
            }

            // Nếu không tìm thấy phần tử
            return -1;
        }
    }
}
