using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Article : IRateAndCopy
    {
       public Person FIO{get;set;}
       public string nameArticle{get;set;}
       public double rating { get; set; }
        public Article(Person person, string arti, double rajting)
        {
            FIO = person;
            nameArticle = arti;
            rating = rajting;
        }
        Article()
        {
            FIO = new Person("Соломон", "Выхухолев", new DateTime(2567, 2, 29));
            nameArticle = "Зачем так жить?";
            rating = 123;

        }
        public override string ToString()
        {
            return " Данные "+ FIO + " название статьи " + nameArticle + " рейтинг " + rating;
        }
        public virtual object DeepCopy()
        {
            Article C1 = new Article();
            C1.FIO = this.FIO;
            C1.nameArticle = this.nameArticle;
            C1.rating = this.rating;
            return C1;
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
