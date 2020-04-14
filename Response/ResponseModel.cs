using System;
using System.Collections.Generic;
using System.Text;

namespace Response
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public bool Status { get; set; }
       
    }
}
