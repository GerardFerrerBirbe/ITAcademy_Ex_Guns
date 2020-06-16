using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Guns
{
    public class ValidationResult
    {
        public string ValidatedResult { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }
    }
}
