using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    interface IRateAndCopy
    {
        object DeepCopy();
        double Rating { get; set; }
    }
}
