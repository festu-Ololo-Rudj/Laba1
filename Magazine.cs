using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variant2
{
    class Magazine : Edition, IRateAndCopy
    {
        private Article[] Art;
        Fr DaTaYear;
        private System.Collections.ArrayList sd = new System.Collections.ArrayList();
        double rating;
        public Magazine(string nP, DateTime dO, int nPu, Fr DY) : base(nP, dO, nPu) { DaTaYear = DY; }

        public Magazine()
        {
            namePublication = "Жизненные позиции";
            dataOut = new DateTime(2013, 3, 24);
            numberPublication = 678;
            DaTaYear = Fr.Monthly;
        }
        public System.Collections.ArrayList ListOfPub
        {
            get { return sd; }
            set { sd = value; }
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public Article[] ListofArt
        {
            get { return Art; }
            set { Art = value; }
        }
        public double middleofrait
        {
            get
            {
                double summ = 0;
                for (int i = 0; i < Art.Length; i++)
                    summ += Art[i].Rating;
                return summ / Art.Length;
            }
        }
        public void AddArticles(params Article[] art)
        {
            for (int i = 0; i < art.Length; i++)
                if (Art[i] == null)
                    Art[i] = art[i];
        }
        public void AddEditors(params Person[] p1)
        {
            for (int i = 0; i < p1.Length; i++)
                sd.Add(p1[i]);
        }
        public override string ToString()
        {
            string s = "" + base.ToString() + "" + DaTaYear;
            for (int i = 0; i < Art.Length; i++)
                s += Art[i].ToString() + "\n";
            for (int i = 0; i < sd.Count; i++)
                s += sd[i].ToString() + "\n";
            return s;
        }
        public virtual string ToShortString()
        {
            return base.ToString() + " " + DaTaYear + " " + middleofrait;
        }
        public override object DeepCopy()
        {
            Magazine C3 = new Magazine();
            C3.Art = this.Art;
            C3.DaTaYear = this.DaTaYear;
            C3.sd = this.sd;
            C3.ed1 = (Edition)base.DeepCopy();
            return C3;
        }
        public Edition ed1
        {
            get { return (Edition)base.DeepCopy(); }
            set { Datas = value.Datas; nedit = value.nedit; npub = value.npub; }
        }
    }
}
