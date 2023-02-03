using System;
using System.Collections.Generic;
using System.Text;

namespace CoreV2.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
