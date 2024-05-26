using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_cs;

namespace userbuilder_task
{
    internal class MiddleNameValidator : IValidator<string?>
    {
        public bool Validate(string? value)
        {
            if (value == null) return false;
            return value[0] >= 65 && value[0] <= 90;
        }
    }
}
