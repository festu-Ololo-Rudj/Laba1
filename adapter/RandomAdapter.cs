using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class RandomAdapter:Generator
    {
        Random d = new Random();
        public int Next()
        {
            return d.Next();
        }
    }
}
