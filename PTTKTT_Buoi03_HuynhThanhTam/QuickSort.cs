using System;

namespace Cau02
{
    public class Quick_Sort
    {
        // Hàm QuickSort chính
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Chia mảng thành hai phần và sắp xếp chúng
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1); // Sắp xếp phần mảng bên trái Pivot
                QuickSort(array, pivotIndex + 1, high); // Sắp xếp phần mảng bên phải Pivot
            }
        }

        // Hàm phân hoạch mảng
        public static int Partition(int[] array, int low, int high)
        {
            // Chọn Pivot là phần tử cuối cùng trong mảng con
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot) // Nếu phần tử nhỏ hơn hoặc bằng Pivot
                {
                    i++;
                    Swap(array, i, j); // Đổi chỗ phần tử
                }
            }
            // Đưa Pivot về đúng vị trí của nó
            Swap(array, i + 1, high);
            return i + 1;
        }

        // Hàm đổi chỗ hai phần tử trong mảng
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
