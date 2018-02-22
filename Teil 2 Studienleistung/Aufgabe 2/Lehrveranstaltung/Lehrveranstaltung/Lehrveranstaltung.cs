using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrveranstaltung
{
    class Lehrveranstaltung
    {
        #region fields
        private int _lvaNummer = 0;
        private int _anmeldungen = 0;
        private static int _laufendeNummer = 0;
        private string _titel = "";
        private DateTime _anmeldeZeitraumMin;
        private DateTime _anmeldeZeitrumMax;
        private List<Student> _studentenList = new List<Student>();
        #endregion


        #region get/set
        public string Titel
        {
            get
            {
                return (_titel);
            }
            set
            {
                _titel = value;
            }
        }

        public static int LaufendeNummer
        {
            get
            {
                return (_laufendeNummer);
            }
            set
            {
                _laufendeNummer = value;
            }
        }

        public DateTime AnmeldeZeitraumMin
        {
            get
            {
                return (_anmeldeZeitraumMin);
            }
            set
            {
                _anmeldeZeitraumMin = value;
            }
        }

        public DateTime AnmeldeZeitrumMax
        {
            get
            {
                return (_anmeldeZeitrumMax);
            }
            set
            {
                _anmeldeZeitrumMax = value;
            }
        }

        public List<Student> StudentenList
        {
            get
            {
                return (_studentenList);
            }
            set
            {
                _studentenList = value;
            }
        }

        public int Anmeldungen
        {
            get
            {
                return (_anmeldungen);
            }
            set
            {
                _anmeldungen = value;
            }
        }

        public int LVANummer
        {
            get
            {
                return (_lvaNummer);
            }
            set
            {
                _lvaNummer = value;
            }
        }
        #endregion


        #region ctor
        public Lehrveranstaltung(string titel, DateTime anmeldezeitraumMin, DateTime anmeldezeitraumMax)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Lehrveranstaltung erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            Titel = titel;
            AnmeldeZeitraumMin = anmeldezeitraumMin;
            AnmeldeZeitrumMax = anmeldezeitraumMax;
            LVANummer = LaufendeNummer;
            LaufendeNummer++;
        }
        #endregion


        #region methods
        //Meldedt einen Studenten in einer Veranstalltung an wenn er noch nicht vorhanden ist
        public void StudentAnmelden(Student student)
        {
            if(!(StudentenList.Contains(student)))
            {
                _studentenList.Add(student);
                Anmeldungen++;
            }
            else
            {
                Console.WriteLine("Student bereits angemeldet");
            }
        }

        //Löscht einen Studenten wenn er vorhanden ist
        public void StudentAbmelden(Student student)
        {
            if(StudentenList.Contains(student))
            {
                _studentenList.Remove(student);
                Anmeldungen--;
            }
            else
            {
                Console.WriteLine("Student nicht angemeldet");
            }
        }

        //Listet alle Studenten in der Veranstaltung auf 
        public void StudentenListen()
        {
            if (StudentenList.Count != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Studenten in " + Titel + ":");
            }
            else
            {
                Console.WriteLine("");
            }
            foreach (Student Key in StudentenList)
            {
                Console.WriteLine("");
                Console.WriteLine("Name:           " + Key.Name);
                Console.WriteLine("Matrikelnummer: " + Key.MatrikelNr);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        #endregion
    }
}
