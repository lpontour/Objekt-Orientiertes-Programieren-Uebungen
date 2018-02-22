using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Abteilung
    {
        #region fields
        private string _bezeichnung = "";
        private Manager _manager = null;
        private List<Mitarbeiter> _mitarbeiterListe = new List<Mitarbeiter>();
        private int _abteilungsnummer = 0;
        private static int _fortlaufendeNummer = 0;
        #endregion


        #region get/set
        public string Bezeichnung
        {
            get
            {
                return (_bezeichnung);
            }
            set
            {
                _bezeichnung = value;
            }
        }

        public Manager Manager
        {
            get
            {
                return (_manager);
            }
            set
            {
                _manager = value;
            }
        }


        public List<Mitarbeiter> Mitarbeiteliste
        {
            get
            {
                return (_mitarbeiterListe);
            }
            set
            {
                _mitarbeiterListe = value;
            }
        }


        public static int FortlaufendeNummer
        {
            get
            {
                return (_fortlaufendeNummer);
            }
            set
            {
                _fortlaufendeNummer = value;
            }
        }


        public int Abteilungsnummer
        {
            get
            {
                return (_abteilungsnummer);
            }
            set
            {
                _abteilungsnummer = value;
            }
        }
        #endregion


        #region ctor
        public Abteilung(string bezeichnung, Manager manager, Mitarbeiter mitarbeiter)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Abteilung erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            _bezeichnung = bezeichnung;
            _manager = manager;
            _mitarbeiterListe.Add(mitarbeiter);
            _abteilungsnummer = _fortlaufendeNummer;
            _fortlaufendeNummer++;
        }
        #endregion


        #region methods
        //Fügt einen Mitarbeiter der Mitarbeiterliste hinzu
        public void Mitarbeiter_einer_Abteilung_Hinzufuegen(Mitarbeiter mitarbeiter)
        {
            _mitarbeiterListe.Add(mitarbeiter);
        }

        //Löscht einen Mitarbeiter aus der Mitarbeiterliste
        public void Mitarbeiter_einer_Abteiung_entfernen(Mitarbeiter mitarbeiter)
        {
            _mitarbeiterListe.Remove(mitarbeiter);
        }
        #endregion
    }
}
