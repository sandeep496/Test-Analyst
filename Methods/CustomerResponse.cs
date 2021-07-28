using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Methods
{
    class CustomerResponse
    {
        //public string message;
        //public string success;
        //public Customer data;
        public bool success { get; set; }
        public Customer data { get; set; }
        public string message { get; set; }
    }
}
