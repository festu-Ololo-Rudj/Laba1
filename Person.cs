using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Person : IRateAndCopy
    {
        private string name;
        private string secondname;
        private System.DateTime mydate;
        private double rating;
        public Person()
        {
            name = " Соломон ";
            secondname = " Выхухолев ";
            mydate = new DateTime(1975, 12, 24);
        }
        public Person(string n, string s, DateTime DT)
        {
            name = n;
            secondname = s;
            mydate = DT;
        }

        string Namee
        {
            get { return name; }
            set { name = value; }
        }
        string LastName
        {
            get { return secondname; }
            set { secondname = value; }
        }
        DateTime DATAYEAR
        {
            get { return mydate; }
            set { mydate = value; }

        }
        int year
        {
            get { return DATAYEAR.Year; }
            set { DATAYEAR = new System.DateTime(value, DATAYEAR.Month, DATAYEAR.Day); }

        }
        public override string ToString()
        {
            return "имя"+" "+ name + "фамилия " +" "+ secondname + "BirthDay " +" "+ mydate.Date.ToString("d");
        }

        public virtual string ToShortString()
        {
            return name + " " + secondname;
        }
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            // If parameter cannot be cast to Point return false
            Person Human = obj as Person;
            if ((Object)Human == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (name == Human.name) && (secondname == Human.secondname) && (mydate == Human.mydate);

        }
        public static bool operator ==(Person P1, Person P2)
        {
            if (Object.ReferenceEquals(P1, P2))
            {
                return true;
            }
            if ((Object)P1 == null || (Object)P2 == null)
            {
                return false;
            }
            return (P1.name == P2.name) && (P1.secondname == P2.secondname) && (P1.mydate == P2.mydate);
        }
        public static bool operator !=(Person P1, Person P2)
        {
            return !(P1 == P2);
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ secondname.GetHashCode() ^ mydate.GetHashCode();
        }
        public virtual object DeepCopy()
        {
            Person C = new Person();
            C.name = this.name;
            C.secondname = this.secondname;
            C.mydate = this.mydate;
            return C;
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public enum Fr { Weekly, Monthly, Yearly };
    }
}
