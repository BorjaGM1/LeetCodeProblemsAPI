namespace LeetCodeAPI.LogicService
{
    public interface IProblems1To10
    {
        int[] Solve2SumsBruteForce(IEnumerable<int> range, int result);
        public LinkedList<int> AddTwoNumbers(LinkedList<int> linked1, LinkedList<int> linked2);
        public int LongestSubstringWithoutRepeatedChars(string input);
        public decimal TwoArraysMedian(IEnumerable<int> array1, IEnumerable<int> array2);
        public string FindLongestPalindromic(string input);
    }
}