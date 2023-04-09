using System.Text;

namespace LeetCodeAPI.LogicService
{
    public class Problems1To10 : IProblems1To10
    {
        public Problems1To10()
        {

        }

        #region 2Sums

        public int[] Solve2SumsBruteForce(IEnumerable<int> inputRange, int result)
        {
            int[] range = inputRange.ToArray();

            int size = range.Length;

            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    int x = range[i];
                    int y = range[j];

                    if (x == y)
                    {
                        continue;
                    }

                    if (x + y == result)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }

        #endregion

        #region AddTwoNumbers

        public LinkedList<int> AddTwoNumbers(LinkedList<int> linked1, LinkedList<int> linked2)
        {
            LinkedList<int> reversed1 = ReverseLinkedListWithStack(linked1);
            LinkedList<int> reversed2 = ReverseLinkedListWithStack(linked2);

            var currentNode1 = reversed1.First;
            var currentNode2 = reversed2.First;

            var result = new LinkedList<int>();

            while (currentNode1 != null && currentNode2 != null)
            {
                result.AddLast(currentNode1.Value + currentNode2.Value);

                currentNode1 = currentNode1.Next;
                currentNode2 = currentNode2.Next;
            }

            return result;
        }

        public LinkedList<int> ReverseLinkedListWithStack(LinkedList<int> linkedList)
        {
            var a = linkedList.ToList();

            Stack<int> stack = new Stack<int>(a);

            var newLinkedList = new LinkedList<int>();

            while (stack.Count > 0)
            {
                var pop = stack.Pop();

                newLinkedList.AddLast(pop);
            }

            return newLinkedList;
        }

        #endregion

        #region LongestSubstring

        public int LongestSubstringWithoutRepeatedChars(string input)
        {
            int result = 0;
            int count = 0;

            if (string.IsNullOrWhiteSpace(input))
            {
                return result;
            }

            var length = input.Length;

            List<char> list = new List<char>(length);

            for (int i = 0; i < length; i++)
            {
                if ((length - i) < result)
                {
                    return result;
                }

                char c = input[i];

                if (!list.Contains(c))
                {
                    list.Add(c);
                    count++;
                }
                else
                {
                    list.Clear();
                    result = Math.Max(result, count);
                    count = 0;
                }
            }

            return result;
        }

        #endregion

        #region TwoArraysMedian

        public decimal TwoArraysMedian(IEnumerable<int> array1, IEnumerable<int> array2)
        {
            decimal result = 0M;

            var input1 = array1.ToArray();
            var input2 = array2.ToArray();

            input1 = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray();
            input2 = new List<int> { 4, 5, 6, 7, 8, 9, 11, 11 }.ToArray();

            var sorted = SortTwoArrays(input1, input2);

            int length = sorted.Length;

            if (length % 2 == 0)
            {
                var a = Convert.ToInt32(((decimal)length / 2) - 0.5M);

                var b = sorted[a];
                var c = sorted[a + 1];

                result = ((decimal)b + (decimal)c) / 2;
            }
            else
            {
                return sorted[length / 2];
            }
            
            return result;
        }

        public int[] SortTwoArrays(int[] input1, int[] input2)
        {
            int[] array3 = new int[input1.Length + input2.Length];

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            while (count1 < input1.Length && count2 < input2.Length)
            {
                if (input1[count1] == input2[count2])
                {
                    array3[count3++] = input1[count1++];
                    array3[count3++] = input2[count2++];
                }
                else if (input1[count1] < input2[count2])
                {
                    array3[count3++] = input1[count1++];
                }
                else if (input1[count1] > input2[count2])
                {
                    array3[count3++] = input2[count2++];
                }
            }

            while (count1 < input1.Length)
            {
                array3[count3++] = input1[count1++];
            }

            while (count2 < input2.Length)
            {
                array3[count3++] = input2[count2++];
            }

            return array3;
        }

        #endregion

        #region LongestPalindromic

        public string FindLongestPalindromic(string input)
        {
            string odd = "asdfgfdsa";

            string even = "asdfggfdsa";

            bool isOdd = IsPalindromic(odd);

            bool isEven = IsPalindromic(even);


            return string.Empty;
        }

        public bool IsPalindromic(string input)
        {
            int size;

            bool isEven = input.Length % 2 == 0;

            if (isEven)
            {
                size = input.Length / 2;
            }
            else
            {
                size = (input.Length - 1) / 2;
            }


            Stack<char> stack = new Stack<char>(input.AsEnumerable());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                stack.TryPop(out char c);

                sb.Append(c);
            }

            string firstHalf = input.Substring(0, size);
            string secondHalf = sb.ToString();

            bool result = firstHalf.Equals(secondHalf);

            return result;
        }

        #endregion
    }
}