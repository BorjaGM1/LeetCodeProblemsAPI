using System.Diagnostics;

namespace LeetCodeAPI
{
    public class CustomResponse
    {
        public Stopwatch sw { get; set; }
        public object result { get; set; }

        public CustomResponse()
        {

        }

        public CustomResponse(Stopwatch time, object response)
        {
            sw = time;
            result = response;
        }
    }
}
