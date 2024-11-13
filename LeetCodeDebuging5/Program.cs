namespace LeetCodeDebuging5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };  // массив с дополнительными нулями
            int m = 3;  
            int[] nums2 = new int[4] { 2, 5, 6, 7 }; 
            int n = 4;  

            solution.Merge(nums1, m, nums2, n);

            Console.WriteLine("Результат объединения:");
            Console.WriteLine(string.Join(", ", nums1));
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n == 0)
            {
                return;
            }

            if (nums1.Length < m + n)
            {
                Array.Resize(ref nums1, m + n);
            }

            int i = m - 1;   // указатель для последнего элемента в nums1, индекс
            int j = n - 1;   // указатель для последнего элемента в nums2, индекс
            int k = m + n - 1;  // указатель для последнего элемента в результирующем массиве nums1, индекс

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            // Добавим оставшиеся элементы из nums2, если они еще есть
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
