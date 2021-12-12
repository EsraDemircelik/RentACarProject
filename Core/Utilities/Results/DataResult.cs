using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //dataresult'ın base i result'tır
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Result voidler için tek fark datası var
        //base demek resulttaki kodları yazmamamızı sağlar
        public DataResult(T data,bool success,string message) : base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool successs):base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
