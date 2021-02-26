using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung {
    public class Parteimitglied : Human {
        //Membervariablen
        private string m_Partei = null;
        //Konstruktoren
        public Parteimitglied(string Name, string Vorname, string partei) : base(Name, Vorname) {

            setPartei(partei);
        }
        public Parteimitglied(string Name, string Vorname) : base(Name, Vorname) {

        }
        //Methoden       
        public string getPartei() {
            return m_Partei;
        }
        public void setPartei(string value) {
            m_Partei = value;
        }
        public new void Datenausgabe() {
            base.Datenausgabe();
            Console.WriteLine(", Partei:" + getPartei());
        }
    }
}
