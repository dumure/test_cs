using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cs
{
    internal class EmailValidator : IValidator<string?>
    {
        public bool Validate(string? value)
        {
            if (value == null) return false;
            return value.Contains("@");
        }
    }
}
