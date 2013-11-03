using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Edition
    {
        protected string namePublication;
        protected DateTime dataOut;
        protected double numberPublication;
        public enum Fr { Weekly, Monthly, Yearly };
        public Edition(string nP, DateTime dO, int nPu)
        {
            namePublication = nP;
            dataOut = dO;
            numberPublication = nPu;
        }
        public Edition()
        {
            namePublication = "Жизненные позиции";
            dataOut = new DateTime(2013, 3, 24);
            numberPublication = 678;
        }
        public string nedit
        {
            get { return namePublication; }
            set { namePublication = value; }
        }
        public DateTime Datas
        {
            get { return dataOut; }
            set { dataOut = value; }
        }
        public double npub
        {
            get { return numberPublication; }
            set
            {
                try
                {
                    if (value < 0)
                        throw new Exc("Ошибка");
                    else
                        numberPublication = value;
                }
                catch (Exc ex) { Console.WriteLine(ex); }
            }

        }
        public virtual object DeepCopy()
        {
            Edition C2 = new Edition();
            C2.namePublication = this.namePublication;
            C2.dataOut = this.dataOut;
            C2.numberPublication = this.numberPublication;
            return C2;
        }
        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            // If parameter cannot be cast to Point return false
            Edition ed = obj as Edition;
            if ((Object)ed == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (namePublication == ed.namePublication) && (dataOut == ed.dataOut) && (numberPublication == ed.numberPublication);
        }
        public static bool operator ==(Edition E1, Edition E2)
        {
            if (Object.ReferenceEquals(E1, E2))
            {
                return true;
            }
            if ((Object)E1 == null || (Object)E2 == null)
            {
                return false;
            }
            return (E1.namePublication == E2.namePublication) && (E1.dataOut == E2.dataOut) && (E1.numberPublication == E2.numberPublication);
        }
        public static bool operator !=(Edition E1, Edition E2)
        {
            return !(E1 == E2);
        }
        public override int GetHashCode()
        {
            return namePublication.GetHashCode() ^ dataOut.GetHashCode() ^ numberPublication.GetHashCode();
        }
        public override string ToString()
        {
            return " Название издания " + " " + namePublication + " Дата выхода в тираж" + " " + dataOut.Date.ToString("d") + " № издания " + " " + numberPublication;
        }
        public Edition(string nP1, DateTime dO1, Fr yeardat, double nPu1)
        {
            nP1 = namePublication;
            dO1 = dataOut;
            nPu1 = numberPublication;
            yeardat = Fr.Monthly;

        }

    }
}
