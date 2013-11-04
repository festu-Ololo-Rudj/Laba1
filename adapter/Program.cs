using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence_Generator SG = new Sequence_Generator();
            SG.Generator1 = new RandomAdapter();
            int[] m1 = SG.Generate(5);
            for (int i = 0; i < m1.Length;i++ )
                Console.WriteLine(m1[i]);
            Console.ReadLine();
        }
    }
}
