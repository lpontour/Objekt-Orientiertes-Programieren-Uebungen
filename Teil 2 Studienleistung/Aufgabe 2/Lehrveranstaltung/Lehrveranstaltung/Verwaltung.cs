using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrveranstaltung
{
    class Verwaltung
    {
        #region fields
        private Dictionary<int, Lehrveranstaltung> _veranstaltungsDic = new Dictionary<int, Lehrveranstaltung>();
        private Dictionary<int, Student> _studentenDic = new Dictionary<int, Student>();

        private static int _laufendeNummerLVA = 0;
        private static int _laufendeNummerStudenten = 0;
        #endregion


        #region get/set
        public Dictionary<int, Student> StudentenDic
        {
            get
            {
                return (_studentenDic);
            }
            set
            {
                _studentenDic = value;
            }
        }

        public Dictionary<int, Lehrveranstaltung> VeranstaltungsDic
        {
            get
            {
                return (_veranstaltungsDic);
            }
            set
            {
                _veranstaltungsDic = value;
            }
        }

        public static int LaufendeNummerLVA
        {
            get
            {
                return (_laufendeNummerLVA);
            }
            set
            {
                _laufendeNummerLVA = value;
            }
        }

        public static int LaufendeNummerStudenten
        {
            get
            {
                return (_laufendeNummerStudenten);
            }
            set
            {
                _laufendeNummerStudenten = value;
            }
        }
        #endregion


        #region ctor

        #endregion


        #region methods
        //Legt eine neue Lehrveranstaltung an
        public void NeueLVA(string titel, DateTime anmeldezeitraumMin, DateTime anmeldezeitraumMax)
        {
            VeranstaltungsDic.Add(LaufendeNummerLVA, new Lehrveranstaltung(titel, anmeldezeitraumMin, anmeldezeitraumMax));
            LaufendeNummerLVA++;
        }

        //Löscht eine Lehrveranstaltung
        public void LVALöschen(int LVANummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Veranstaltung " + VeranstaltungsDic[LVANummer].Titel + " gelöscht");
            Console.WriteLine("");
            Console.WriteLine("");
            VeranstaltungsDic.Remove(LVANummer);
        }

        //Listet Lehrveranstaltungen und ihre Studenten auf
        public void LVAListe()
        {
                Console.WriteLine("");
                Console.WriteLine("Lehrveranstaltungen:");
                Console.WriteLine("");
                foreach (Lehrveranstaltung Key in VeranstaltungsDic.Values)
            {
                Console.WriteLine("Veranstatungsname:    " + Key.Titel);
                Console.WriteLine("Veranstaltungsnummer: " + Key.LVANummer);
                Console.WriteLine("Anmeldebeginn:        " + Key.AnmeldeZeitraumMin.ToShortDateString());
                Console.WriteLine("Anmeldeschluss:       " + Key.AnmeldeZeitrumMax.ToShortDateString());
                Console.WriteLine("Anmeldungen:          " + Key.Anmeldungen);
                Key.StudentenListen();
            }
        }
        
        //Legt einen Studenten an
        public void Studentanlegen(string name)
        {
            StudentenDic.Add(LaufendeNummerStudenten, new Student(name));
            LaufendeNummerStudenten++;
        }

        //Löscht einen Studenten
        public void StudentLöschen(int matrikelNr)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Student " + StudentenDic[matrikelNr].Name + " gelöscht");
            Console.WriteLine("");
            Console.WriteLine("");
            StudentenDic.Remove(matrikelNr);
        }

        //Listet alle Studenten auf
        public void StudentenListen()
        {
            Console.WriteLine("");
            Console.WriteLine("Alle Studenten");
            Console.WriteLine("");
            foreach (Student Key in StudentenDic.Values)
            {
                Console.WriteLine("");
                Console.WriteLine("Name:           " + Key.Name);
                Console.WriteLine("Matrikelnummer: " + Key.MatrikelNr);
            }
        }

        //Meldet einen Studenten bei einer Lehrveranstaltung an
        public void StudentBeiVeranstalungAnmelden(Student student, Lehrveranstaltung lehrveranstaltung)
        {
            if(IstImIntervall(DateTime.Now, lehrveranstaltung.AnmeldeZeitraumMin, lehrveranstaltung.AnmeldeZeitrumMax))
            {
                lehrveranstaltung.StudentAnmelden(student);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(student.Name + " bei " + lehrveranstaltung.Titel + " angemeldet");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Anmeldung ausserhalb des Anmeldezeitraums");
            }
        }

        //Löscht einen Studenten bei einer Lehrveranstaltung
        public void StudentBeiVeranstalungAbmelden(Student student, Lehrveranstaltung lehrveranstaltung)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(student.Name + " bei " + lehrveranstaltung.Titel + " abgemeldet");
            Console.WriteLine("");
            Console.WriteLine("");
            lehrveranstaltung.StudentAbmelden(student);
        }

        //Prüft ob ein DateTime zwischen zwei anderen DateTime's liegt
        public static bool IstImIntervall(DateTime dateTime, DateTime vonDateTime, DateTime bisDateTime)
        {
            return (dateTime >= vonDateTime && dateTime <= bisDateTime);
        }
        #endregion
    }
}
