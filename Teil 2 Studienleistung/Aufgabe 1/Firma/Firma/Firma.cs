using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Firma
    {
        #region fields
        private string _name = "";
        private Dictionary<int, Mitarbeiter> _dicMitarbeiter = new Dictionary<int, Mitarbeiter>();
        private Dictionary<int, Manager> _dicManager = new Dictionary<int, Manager>();
        private Dictionary<int, Vertreter> _dicVertreter = new Dictionary<int, Vertreter>();

        private Dictionary<int, Abteilung> _dicAbteilung = new Dictionary<int, Abteilung>();

        private Dictionary<int, Kunden> _dicKunden = new Dictionary<int, Kunden>();
        private Dictionary<int, Stammkunden> _dicStammkunden = new Dictionary<int, Stammkunden>();
        #endregion


        #region get/set
        public Dictionary<int, Mitarbeiter> DicMitarbeiter
        {
            get
            {
                return (_dicMitarbeiter);
            }
            set
            {
                _dicMitarbeiter = value;
            }
        }


        public Dictionary<int, Manager> DicManager
        {
            get
            {
                return (_dicManager);
            }
            set
            {
                _dicManager = value;
            }
        }


        public Dictionary<int, Vertreter> DicVertreter
        {
            get
            {
                return (_dicVertreter);
            }
            set
            {
                _dicVertreter = value;
            }
        }


        public Dictionary<int, Abteilung> DicAbteilung
        {
            get
            {
                return (_dicAbteilung);
            }
            set
            {
                _dicAbteilung = value;
            }
        }


        public Dictionary<int, Stammkunden> DicStammkunden
        {
            get
            {
                return (_dicStammkunden);
            }
            set
            {
                _dicStammkunden = value;
            }
        }


        public Dictionary<int, Kunden> DicKunden
        {
            get
            {
                return (_dicKunden);
            }
            set
            {
                _dicKunden = value;
            }
        }
        #endregion


        #region ctor
        public Firma(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Firma erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            _name = name;
        }
        #endregion


        #region methods
        //Fügt einen Kunden hinzu
        public void KundenHinzufuegen(string name, string ort, int plz, string straße, string hausnummer)
        {
            _dicKunden.Add(Kunden.FortlaufendeNummer, new Kunden(name, ort, plz, straße, hausnummer));
        }

        //Fügt einen Stammkunden hinzu
        public void StammKundenHinzufuegen(Kunden kunde, int rabatInProzentZahl)
        {
            _dicKunden.Remove(kunde.Kundennummer);
            _dicStammkunden.Add(kunde.Kundennummer, kunde.ZuStammkundenMachen(rabatInProzentZahl));
        }

        //Entfernt einen Kunden wieder
        public void KundenEntfernen(Kunden kunde)
        {
            _dicKunden.Remove(kunde.Kundennummer);
        }

        //Fügt einen Mitarbeiter hinzu
        public void MitarbeiterHinzufuegen(string name, string ort, int plz, string straße, string hausnummer, double gehalt)
        {
            _dicMitarbeiter.Add(Mitarbeiter.FortlaufendeNummer, new Mitarbeiter(name, ort, plz, straße, hausnummer, gehalt));
        }

        //Macht einen Mitarbeiter zum Vertreter 
        public void MitarbeiterZuVertreterMachen(Mitarbeiter mitarbeiter, string vertriebsregion)
        {
            _dicMitarbeiter.Remove(mitarbeiter.Personalnummer);
            _dicVertreter.Add(Mitarbeiter.FortlaufendeNummer, mitarbeiter.ZuVertreterMachen(vertriebsregion));
        }

        //Macht einen Mitarbeiter zum Manager
        public void MitarbeiterZuManagerMachen(Mitarbeiter mitarbeiter, double bonus, params Abteilung[] abteilung)
        {
            _dicMitarbeiter.Remove(mitarbeiter.Personalnummer);
            try
            {
                _dicManager.Add(mitarbeiter.Personalnummer, mitarbeiter.ZuManagerMachen(bonus, abteilung[0]));
            }
            catch
            {
                _dicManager.Add(mitarbeiter.Personalnummer, mitarbeiter.ZuManagerMachen(bonus));
            }
        }

        //Erstellt eine Abteilung
        public void AbteilungErstellen(string bezeichnung, Manager manager, Mitarbeiter mitarbeiter)
        {
            _dicAbteilung.Add(Abteilung.FortlaufendeNummer, new Abteilung(bezeichnung, manager, mitarbeiter));
            manager.Abteilung = _dicAbteilung[(Abteilung.FortlaufendeNummer - 1)];
        }

        //Löscht eine Abteilung
        public void AbteilungEntfernen(int abteilungsnummer)
        {
            _dicAbteilung.Remove(abteilungsnummer);
        }

        //Weist einer Abteilung einen Manger(neu) zu
        public void ManagerAbteilungZuweisen(Manager manager, Abteilung abteilung, Mitarbeiter mitarbeiter)
        {
            _dicAbteilung.Remove(abteilung.Abteilungsnummer);
            _dicAbteilung.Add(abteilung.Abteilungsnummer, new Abteilung(abteilung.Bezeichnung, manager, mitarbeiter));

        }
        #endregion
    }
}
