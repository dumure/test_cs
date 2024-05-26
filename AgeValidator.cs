using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cs
{
    internal class AgeValidator : IValidator<DateTime?>
    {
        public bool Validate(DateTime? value)
        {
            if (value == null) return false;
            return (DateTime.Now - value)?.Days/365.0 >= 18;
        }
    }
}
