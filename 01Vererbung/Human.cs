using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung {
    public abstract class Human {
        protected string m_Name;
        protected string m_Vorname;

        public Human(string name, string vorname) {
            m_Name = name;
            m_Vorname = vorname;
        }

        public string getName() {
            return m_Name;
        }
        public void setName(string value) {
            m_Name = value;
        }
        public string getVorname() {
            return m_Vorname;
        }
        public void setVorname(string value) {
            m_Vorname = value;
        }
        public void Datenausgabe() {
            Console.Write("Name und Vorname: " + getName() + " " + getVorname());
        }

        protected string getTyp() {
            return "Human";
        }
        protected string getInfos() {
            return "I am Human";
        }
    }

}
