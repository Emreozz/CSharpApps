using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> where T:class,IEntity,new()
    {
        public List<T> Data { get; }
        public DataResult(List<T> data,bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(List<T> data,bool success):base(success)
        {
            Data=data;
        }

        
    }
}
