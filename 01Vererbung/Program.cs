using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mitarbeiter
            Mitarbeiter m1 = new Mitarbeiter("Kunigunde", "Hugentobler", 4800.00, "Roche");
            Mitarbeiter m2 = new Mitarbeiter("Adelheit", "Joggenmoser", 6200.00, "Siemens");
            Mitarbeiter m3 = new Mitarbeiter("Melchior", "Käser");
            m3.setLohn(5900.00);
            m3.setFirma("Roche");
            //Parteimitglieder
            Parteimitglied pm1 = new Parteimitglied("Blocher", "Christoph", "SVP");
            Parteimitglied pm2 = new Parteimitglied("Brunner", "Heidi", "FDP");
            //Politiker
            Politiker po1 = new Politiker("Maurer", "Ueli", 33000, "SVP", "Bundesrat");
            Politiker po2 = new Politiker("Burkhalter", "Didier", 33000, "FDP", "Bundesrat");
            Politiker po3 = new Politiker("Schneider-Ammann", "Johann", 33000, "FDP", "Bundesrat");
            Politiker po4 = new Politiker("Sommaruga", "Simmonetta", 33000, "SP", "Bundesrat");
            Politiker po5 = new Politiker("Parmelat", "Guy", 33000, "SVP", "Bundesrat");
            Politiker po6 = new Politiker("Berset", "Alain", 33000, "SP", "Bundesrat");
            Politiker po7 = new Politiker("Leuthard", "Doris", 33000, "CVP", "Bundesrat");
            Politiker po9 = new Politiker("Levrat", "Christian", 100000, "SP", "Nationalrat");
            Politiker po8 = new Politiker("Schelbert", "Louis", 100000, "Grüne", "Nationalrat");
            Politiker po10 = new Politiker("Darbellay", "Christoph", 100000, "CVP", "Nationalrat");
            Politiker po11 = new Politiker("Brunner", "Toni", 100000, "SVP", "Nationalrat");
            Politiker po12 = new Politiker("Höltschi", "Pius", 6000, "SVP", "Kantonsrat");

            //
            Funktionen.Lohnerhoehung(m1, 1.20);
            Funktionen.Lohnerhoehung(po12, 2.50);
            //
            m1.Datenausgabe();
            m2.Datenausgabe();
            m3.Datenausgabe();
            pm1.Datenausgabe();
            pm2.Datenausgabe();
            po1.Datenausgabe();
            po2.Datenausgabe();
            po3.Datenausgabe();
            po4.Datenausgabe();
            po5.Datenausgabe();
            po6.Datenausgabe();
            po7.Datenausgabe();
            po8.Datenausgabe();
            po9.Datenausgabe();
            po10.Datenausgabe();
            po11.Datenausgabe();
            po12.Datenausgabe();
            //
            Console.ReadLine();
        }
    }
}
