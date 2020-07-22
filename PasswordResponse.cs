using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADPasswordManager
{
    public class PasswordResponse
    {
        public bool Success { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
