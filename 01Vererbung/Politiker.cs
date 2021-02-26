using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung {
    public class Politiker : Parteimitglied, Economy {
        //Membervariablen
        private double m_Lohn;
        private string m_Rat = null;
        //Konstruktoren
        public Politiker(string Name, string Vorname, double l, string p, string r) : base(Name, Vorname, p) {
            setLohn(l);
            setRat(r);
        }
        public Politiker(string Name, string Vorname) : base(Name, Vorname) {

        }

        public double getLohn() {
            return m_Lohn;
        }
        public void setLohn(double value) {
            m_Lohn = value;
        }
        public string getRat() {
            return m_Rat;
        }
        public void setRat(string value) {
            m_Rat = value;
        }
        public new void Datenausgabe() {
            base.Datenausgabe();
            Console.WriteLine(", Lohn:" + getLohn() + ", Rat: " + getRat());
        }
    }
}
