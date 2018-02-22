using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Seminar
    {
        #region field
        private string _kuerzel = "";
        private string _titel = "";
        private string _dozent = "";
        private int _anmeldungen = 0;
        private int _maxanmeldungen = 0;
        private static int _laufendeNr = 0;
        private int _seminarNr = 0;
        private double _kosten = 0.0;
        private double _mwSt = 2.4;
        private DateTime _anfang = new DateTime();
        private DateTime _ende = new DateTime();
        private List<Firma> _teilnehmerFirmenListe = new List<Firma>();
        private List<Einzelpersonen> _teilnehmerEinzelpersonenListe = new List<Einzelpersonen>();

        #endregion

        #region get/set
        public int SeminatNr
        {
            get
            {
                return (_seminarNr);
            }
            set
            {
                _seminarNr = value;
            }
        }

        public static int LaufendeNr
        {
            get
            {
                return (_laufendeNr);
            }
            set
            {
                _laufendeNr = value;
            }
        }

        public List<Einzelpersonen> TeilnehmerEinzelpersonenListe
        {
            get
            {
                return (_teilnehmerEinzelpersonenListe);
            }
            set
            {
                _teilnehmerEinzelpersonenListe = value;
            }
        }

        public List<Firma> TeilnehmerFirmenListe
        {
            get
            {
                return (_teilnehmerFirmenListe);
            }
            set
            {
                _teilnehmerFirmenListe = value;
            }
        }

        public DateTime Ende
        {
            get
            {
                return (_ende);
            }
            set
            {
                _ende = value;
            }
        }

        public DateTime Anfang
        {
            get
            {
                return (_anfang);
            }
            set
            {
                _anfang = value;
            }
        }

        public double MwSt
        {
            get
            {
                return (_mwSt);
            }
            set
            {
                _mwSt = value;
            }
        }

        public double Kosten
        {
            get
            {
                return (_kosten);
            }
            set
            {
                _kosten = value;
            }
        }

        public int MaxAnmeldungen
        {
            get
            {
                return (_maxanmeldungen);
            }
            set
            {
                _maxanmeldungen = value;
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

        public string Dozent
        {
            get
            {
                return (_dozent);
            }
            set
            {
                _dozent = value;
            }
        }

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

        public string Kuerzel
        {
            get
            {
                return (_kuerzel);
            }
            set
            {
                _kuerzel = value;
            }
        }
        #endregion

        #region ctor
        public Seminar (string kuerzel, string titel, string dozent, int maxAnmeldungen, double kosten, DateTime anfang, DateTime ende)
        {
            Kuerzel = kuerzel;
            Titel = titel;
            Dozent = dozent;
            MaxAnmeldungen = maxAnmeldungen;
            Kosten = kosten;
            Anfang = anfang;
            Ende = ende;
            SeminatNr = LaufendeNr;
            LaufendeNr++;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Seminar erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        #endregion

        #region methods

        //Meldet wenn moeglich eine Firma beim Seminar an
        public void FirmaAnmelden(Firma firma, string freitext)
        {
            if ((Anmeldungen + firma.AnzahlTeilnehmer) <= MaxAnmeldungen)
            {
                TeilnehmerFirmenListe.Add(firma);
                firma.Anmeldebestaetigung = new Anmeldebestaetigung(freitext);
                firma.Rechnung = new Rechnung((Kosten * firma.AnzahlTeilnehmer), MwSt);
            }
            else
            {
                Console.WriteLine("Zu viele Teilnehmer! Nur noch " + (MaxAnmeldungen - Anmeldungen) + " Plätze frei!");
            }
        }

        //Meldet wenn moeglich eine Person zum Seminar an
        public void EinzelpersonenAnmelden(Einzelpersonen einzelpersonen, string freitext)
        {
            if ((Anmeldungen + 1) <= MaxAnmeldungen)
            {
                TeilnehmerEinzelpersonenListe.Add(einzelpersonen);
                einzelpersonen.Anmeldebestaetigung = new Anmeldebestaetigung(freitext);
                einzelpersonen.Rechnung = new Rechnung(Kosten, MwSt);
            }
            else
            {
                Console.WriteLine("Veranstaltung bereits voll!");
            }
        }
        #endregion
    }
}
