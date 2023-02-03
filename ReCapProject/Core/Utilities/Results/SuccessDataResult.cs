using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T> where T:class,IEntity,new()
    {
        public SuccessDataResult(List<T> data,  string message) : base(data, true, message)
        {
        }
        public SuccessDataResult(List<T>data):base(data,true)
        {

        }
    }
}

