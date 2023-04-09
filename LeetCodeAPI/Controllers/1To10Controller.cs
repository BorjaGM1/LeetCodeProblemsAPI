using LeetCodeAPI.LogicService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeetCodeAPI.Controllers
{
    [ApiController]
    [Route("/api")]
    public class Problems1To10Controller : ControllerBase
    {

        private ILogger<Problems1To10Controller> _logger { get; }
        protected IProblems1To10 _service { get; }

        public Problems1To10Controller(ILogger<Problems1To10Controller> logger, IProblems1To10 service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("/twosums")]
        public IActionResult TwoSums(IEnumerable<int> input, int expectedresult)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int[] result = _service.Solve2SumsBruteForce(input, expectedresult);

            sw.Stop();

            CustomResponse customResponse = new CustomResponse(sw, result);

            return Ok(customResponse);
        }

        [HttpPost("/addtwonumbers")]
        public IActionResult AddTwoNumbers([FromForm]LinkedList<int> input1, [FromForm]LinkedList<int> input2)
        {
            Stopwatch sw = Stopwatch.StartNew();

            var result = _service.AddTwoNumbers(input1, input2);

            sw.Stop();

            CustomResponse customResponse = new CustomResponse(sw, result);

            return Ok(result);
        }

        [HttpGet("/longestsubstring")]
        public IActionResult LongestSubstring([FromQuery] string input)
        {
            Stopwatch sw = Stopwatch.StartNew();

            var result = _service.LongestSubstringWithoutRepeatedChars(input);

            sw.Stop();

            CustomResponse customResponse = new CustomResponse(sw, result);

            return Ok(result);
        }

        [HttpPost("/twoarraysmedian")]
        public IActionResult TwoArraysMedian([FromForm]IEnumerable<int> array1, [FromForm] IEnumerable<int> array2)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int[] array11 = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray();
            int[] array22 = new List<int> { 4, 5, 6, 7, 8, 9, 11, 11 }.ToArray();

            var result = _service.TwoArraysMedian(array11, array22);

            sw.Stop();

            CustomResponse customResponse = new CustomResponse(sw, result);

            return Ok(customResponse);
        }

        [HttpGet("longestpalindromic")]
        public IActionResult GetLongestPalindromic([FromQuery] string input)
        {
            Stopwatch sw = Stopwatch.StartNew();

            var result = _service.FindLongestPalindromic(input);

            sw.Stop();

            CustomResponse customResponse = new CustomResponse(sw, result);

            return Ok(customResponse);
        }
    }
}