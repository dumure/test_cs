using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_cs;

namespace userbuilder_task
{
    internal class AddressValidator : IValidator<string?>
    {
        public bool Validate(string? value)
        {
            return value != null;
        }
    }
}
