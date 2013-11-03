using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Program
    {
        static void Main(string[] args)
        {
            Edition E1 = new Edition(" Все очень плохо ", new DateTime(2013, 1, 23), 135);
            Edition E2 = new Edition(" Все очень плохо ", new DateTime(2013, 1, 23), 135);
            Magazine M1 = new Magazine();
            M1.ListofArt = new Article[1];
            M1.AddArticles(new Article(new Person(), " жизнь боль ", 234));
            Console.WriteLine(M1.ToShortString());
            M1.AddEditors(new Person(), new Person(" Василий "," Жучков ",new DateTime(1974, 11, 23)));
            Console.WriteLine(M1.ToString());
            Console.WriteLine("Ссылки равны - " + ReferenceEquals(E1, E2).ToString());
            Console.WriteLine("Объекты равны-" + E1.Equals(E2).ToString());
            Console.WriteLine("Hash-code-1: " + E1.GetHashCode().ToString());
            Console.WriteLine("Hash-code-2: " + E2.GetHashCode().ToString()); 
            E1.npub = -1;
            Console.Write(M1.ed1.ToString());
            Magazine M2 = (Magazine)M1.DeepCopy();
            M1.nedit = "Тлен";
            Console.WriteLine();
            Console.WriteLine("Исходный " + M1.ToShortString());
            Console.WriteLine("Копия " + M2.ToShortString());
            Console.WriteLine();
            foreach (Article A in M1.ListofArt)
                if(A.Rating>24)
                Console.WriteLine(A.ToString());
            foreach(Article B in M1.ListofArt)
                if(B.nameArticle.Contains(" жизнь "))
                    Console.WriteLine(B.ToString());
            Console.ReadLine();

        }
    }
}
