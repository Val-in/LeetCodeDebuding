namespace LeetCodeDebuging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            while (true)
            {
                Console.WriteLine("Введите текст без знаков препинания, будет посчитано количество символов в последнем слове.");
                string input = Console.ReadLine();
                int result = solution.LengthOfLastWord(input);
                Console.WriteLine("Количество символов в последнем слове " + result);
            }
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            int lastSpace = s.LastIndexOf(' ');
            return s.Length - lastSpace - 1;
        }
    }
}
