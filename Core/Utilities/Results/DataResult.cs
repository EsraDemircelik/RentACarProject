using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //base demek resulttaki kodları yazmamamızı sağlar
    //dataresult'ın base i result'tır
    public class DataResult<T> : Result, IDataResult<T>
    {
        //?
        private static bool success;

        public DataResult(T data,bool success,string message) : base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool successs) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
