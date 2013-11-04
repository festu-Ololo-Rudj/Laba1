using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proksi
{
    class ProxySubject:Subject
    {
        private RealSubject rs = null;
        public int Request() 
        {
           
                if (rs==null)
                     rs=new RealSubject();
            return rs.Request();}
        }
}
