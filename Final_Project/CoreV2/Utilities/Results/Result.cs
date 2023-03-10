using System;
using System.Collections.Generic;
using System.Text;

namespace CoreV2.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
        public Result(bool success,string message):this(success)
        {
            
            this.Message=message;
        }
        public Result(bool success)
        {
            this.Success = success;
        }
    }
}
