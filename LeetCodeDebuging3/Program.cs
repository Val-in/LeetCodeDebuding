namespace LeetCodeDebuging3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Solution solution = new Solution();

                Console.WriteLine("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                bool result = solution.IsPalindrome(number);
                Console.WriteLine(result);
            }
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int reversed = 0;
            int original = x;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;  // сдвигает число справа налево, удаляя последнюю цифру
            }
            return x == reversed || x == reversed / 10;
        }
    }
}
