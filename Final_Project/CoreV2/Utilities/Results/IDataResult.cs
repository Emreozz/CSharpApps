using System;
using System.Collections.Generic;
using System.Text;

namespace CoreV2.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
