using LeetCodeAPI.LogicService;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCodeTests
{
    public class Tests1To10
    {
        protected Problems1To10 _service { get; }

        public Tests1To10()
        {
            _service = new Problems1To10();
        }


        [Fact]
        public void Assert2SumsBruteForce()
        {
            var range = Enumerable.Range(0, 1000);

            int[] inputRange = range.ToArray();

            int expectedResult = 7;

            int[] rangeResult = _service.Solve2SumsBruteForce(inputRange, expectedResult);

            int index1 = rangeResult[0];
            int index2 = rangeResult[1];

            Assert.Equal(expectedResult, inputRange[index1] + inputRange[index2]);
        }

        [Fact]
        public void AssertTwoSums()
        {
            LinkedList<int> linked1 = new LinkedList<int>(new int[] { 2, 4, 5});
            LinkedList<int> linked2 = new LinkedList<int>(new int[] { 5, 6, 4});

            var result = _service.AddTwoNumbers(linked1, linked2);
            
            Assert.Equal(result, new LinkedList<int>(new int[] { 9, 10, 7 }));
        }

        [Fact]
        public void AssertReversedLinkedListWithStack()
        {
            LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6 });

            var result = _service.ReverseLinkedListWithStack(linkedList);

            Assert.Equal(result, new LinkedList<int>(new int[] { 6, 5, 4, 3, 2, 1 }));
        }

        [Fact]
        public void AssertLongestSubstring()
        {
            string input = "asdfgggaaaaaaaassssssddddfgasdffffggggaa";

            int expectedResult = 5;

            int result = _service.LongestSubstringWithoutRepeatedChars(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AssertTwoArraysMedian()
        {
            int[] array1 = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray();
            int[] array2 = new List<int> { 4, 5, 6, 7, 8, 9, 11, 11 }.ToArray();

            decimal expectedResult = 5.5M;

            decimal result = _service.TwoArraysMedian(array1, array2);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AssertSortTwoArrays()
        {
            int[] array1 = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray();
            int[] array2 = new List<int> { 4, 5, 6, 7, 8, 9, 11, 11 }.ToArray();

            int[] expectedResult = new List<int> { 1, 2, 3, 4, 4, 5, 5, 6, 6, 7, 8, 9, 11, 11 }.ToArray();

            int[] result = _service.SortTwoArrays(array1, array2);

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void AssertIsPalindromicOdd()
        {
            string input = "asdfgfdsa";

            bool result = _service.IsPalindromic(input);

            Assert.True(result);
        }

        [Fact]
        public void AssertIsPalindromicEven()
        {
            string input = "asdfggfdsa";

            bool result = _service.IsPalindromic(input);

            Assert.True(result);
        }
    }
}