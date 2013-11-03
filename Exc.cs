using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Exc : Exception
    {
        public Exc() : base() { }
        public Exc(string str) : base(str) { }
        public Exc(string str, Exception inner) : base(str, inner) { }
        protected Exc(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
