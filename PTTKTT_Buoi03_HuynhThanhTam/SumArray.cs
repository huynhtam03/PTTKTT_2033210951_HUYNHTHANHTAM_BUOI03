using System;

namespace Cau01
{
    public class Sum_Array
    {
        // Hàm tính tổng mảng không đệ quy
        public static int SumArrayIterative(int[] array, int n)
        {
            int sum = 0;
            for (int i = 0; i <= n ; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        // Hàm tính tổng mảng bằng đệ quy
        public static int SumArrayRecursive(int[] array, int n)
        { 
            if (n < 0) // Điều kiện dừng
                return 0;
            else
                return array[n] + SumArrayRecursive(array, n - 1);
        }
    }
}
