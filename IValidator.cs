using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_cs
{
    internal interface IValidator<T>
    {
        bool Validate(T value);
    }
}
