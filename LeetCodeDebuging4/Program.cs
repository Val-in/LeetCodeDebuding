namespace LeetCodeDebuging4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 4;

            // Создаем экземпляр класса Solution
            Solution solution = new Solution();

            // Вызываем метод SearchInsert и сохраняем результат
            int index = solution.SearchInsert(nums, target);

            // Выводим результат
            Console.WriteLine($"Индекс для вставки элемента {target}: {index}");
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
