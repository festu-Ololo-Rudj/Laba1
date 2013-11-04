using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random e = new Random();
            Subject[] m=new Subject[5];
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < m.Length; i++)
            {
              //m[i] = new RealSubject();
                m[i] = new ProxySubject();

               
            }
            
            int a = e.Next(0, m.Length);
           Console.WriteLine(m[a].Request());
            Console.WriteLine(DateTime.Now);
           Console.ReadLine();
        }
    }
}
