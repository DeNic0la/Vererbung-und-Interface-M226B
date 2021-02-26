using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung {
    public class Mitarbeiter : Human, Economy {
        //Membervariablen
        private double m_Lohn;
        private string m_Firma;
        //Konstruktoren
        public Mitarbeiter(string Name, string Vorname) : base(Name, Vorname) {

        }
        public Mitarbeiter(string Name, string Vorname, double Lohn, string firma) : base(Name, Vorname) {
            setLohn(Lohn);
            setFirma(firma);
        }
        public double getLohn() {
            return m_Lohn;
        }
        public void setLohn(double value) {
            m_Lohn = value;
        }
        public string getFirma() {
            return m_Firma;
        }
        public void setFirma(string value) {
            m_Firma = value;
        }
        public new void Datenausgabe() {
            base.Datenausgabe();
            Console.WriteLine(" Lohn:" + getLohn() + ", Firma:" + getFirma());
        }
    }
}
