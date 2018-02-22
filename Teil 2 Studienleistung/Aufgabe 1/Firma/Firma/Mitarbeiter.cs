using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Mitarbeiter : Person
    {
        #region fields
        private static int _fortlaufendeNummer = 0;
        private int _personalnummer = 0;
        private double _gehalt = 0;
        #endregion


        #region get/set
        public int Personalnummer
        {
            get
            {
                return (_personalnummer);
            }
            set
            {
                _personalnummer = value;
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


        public double Gehalt
        {
            get
            {
                return (_gehalt);
            }
            set
            {
                _gehalt = value;
            }
        }
        #endregion


        #region ctor
        //Normler Konstruktor für das hinzufügen von Mitarbeitern
        public Mitarbeiter(string name, string ort, int plz, string straße, string hausnummer, double gehalt) : base(name, ort, plz,straße, hausnummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Mitarbeiter eingestellt");
            Console.WriteLine("");
            Console.WriteLine("");
            _gehalt = gehalt;
            _personalnummer = _fortlaufendeNummer;
            _fortlaufendeNummer++;
        }

        //Konstruktor um einen Mitarbeiter wieder von einem Vertreter oder Manager zu einem Mitarbeiter zu machen
        public Mitarbeiter(string name, string ort, int plz, string straße, string hausnummer, double gehalt, int personalnummer) : base(name, ort, plz, straße, hausnummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Manager oder Vertreter wieder zu Mitarbeiter gemacht");
            Console.WriteLine("");
            Console.WriteLine("");
            _gehalt = gehalt;
            _personalnummer = personalnummer;
        }
        #endregion


        #region methods
        //Macht aus einem Mitarbeiter zu einem Vertreter und gibt diesen zurück
        public Vertreter ZuVertreterMachen(string vertriebsregion)
        {
            return(new Vertreter(base.Name, base.Ort, base.PLZ, base.Straße, base.Hausnummer, Personalnummer, Gehalt, vertriebsregion));
        }

        //Macht aus einem Mitarbeiter zu einem Manager und gibt diesen zurück
        public Manager ZuManagerMachen(double bonus, params Abteilung[] abteilung)
        {
            try
            {
                return (new Manager(base.Name, base.Ort, base.PLZ, base.Straße, base.Hausnummer, Personalnummer, Gehalt, bonus, abteilung[0]));
            }
            catch
            {
                return (new Manager(base.Name, base.Ort, base.PLZ, base.Straße, base.Hausnummer, Personalnummer, Gehalt, bonus));
            }
        }
        #endregion
    }
}
