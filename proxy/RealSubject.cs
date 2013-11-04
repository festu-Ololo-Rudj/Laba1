using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Proksi
{
    class RealSubject:Subject
    {
        public RealSubject() { Thread.Sleep(2000); }
        public int Request() { return 10; }
    }
}
