using LeetCodeAPI.LogicService;
using Xunit;

namespace Tests
{
    public class Tests1To10 : IClassFixture<IProblems1To10>
    {
        protected IProblems1To10 _service { get; }

        public Tests1To10(IProblems1To10 service)
        {
            _service = service;
        }

        [Fact]
        public void RandomTest()
        {
            Assert.True(true);
        }


        [Fact]
        public void Assert2SumsBruteForce()
        {
            int[] inputRange = new int[] { 1, 2, 3, 4, 5};

            int expectedResult = 7;

            int[] rangeResult = _service.Solve2SumsBruteForce(inputRange, expectedResult);

            int index1 = rangeResult[0];
            int index2 = rangeResult[1];

            Assert.Equal(expectedResult, inputRange[index1] + inputRange[index2]);
        }
    }
}