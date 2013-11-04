using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Sequence_Generator
    {
       
        public Generator Generator1;
        public int[] Generate(int length)
        {
            int[] m=new int[length];
           for (int i = 0; i < length; i++)
                m[i] = Generator1.Next();
           return m;
        }
    }
}
