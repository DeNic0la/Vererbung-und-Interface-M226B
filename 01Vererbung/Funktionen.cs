using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung {
    public class Funktionen {
        public static void Lohnerhoehung(Economy e, double d) {
            double dAlterLohn = e.getLohn();
            double dNeuerLohn = dAlterLohn / 100 * (100 + d);
            e.setLohn(dNeuerLohn);
        }

    }
}
