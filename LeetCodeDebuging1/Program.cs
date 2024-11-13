namespace LeetCodeDebuging1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("Введите числа через пробел:");
            string input = Console.ReadLine();

            int[] nums = input.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Введите число, которое нужно удалить:");
            int deleted = int.Parse(Console.ReadLine());

            int result = solution.RemoveElement(nums, deleted);
            Console.WriteLine("Количество элементов после удаления: " + result);
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
    }
}
