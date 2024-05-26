using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cs
{
    internal class NameValidator : IValidator<string>
    {
        public bool Validate(string value)
        {
            return value[0] >= 65 && value[0] <= 90;
        }
    }
}
