using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorClient.Shared
{
    public class ResponseObject<T> where T : class
    {
        public bool Ok { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public ResponseObject() { }
    }
}
