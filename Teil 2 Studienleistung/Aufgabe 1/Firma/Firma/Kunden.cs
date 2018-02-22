using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Kunden : Person
    {
        #region fields
        private static int _fortlaufendeNummer = 0;
        private int _kundennummer = 0;
        #endregion


        #region get/set
        public int Kundennummer
        {
            get
            {
                return (_kundennummer);
            }
            set
            {
                _kundennummer = value;
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
        #endregion


        #region ctor
        //Kunden erstellen
        public Kunden(string name, string ort, int plz, string straße, string hausnummer) : base(name, ort, plz, straße, hausnummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Kunden angelegt");
            Console.WriteLine("");
            Console.WriteLine("");
            _kundennummer = _fortlaufendeNummer;
            _fortlaufendeNummer++;
        }

        //Stammkunden wieder zu Kunden machen
        public Kunden(string name, string ort, int plz, string straße, string hausnummer, int kundennummer) : base(name, ort, plz, straße, hausnummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Stammkunden wieder zu Kunden gemacht");
            Console.WriteLine("");
            Console.WriteLine("");
            _kundennummer = kundennummer; 
        }
        #endregion


        #region methods
        //Macht einen Kunden zum Stammkunden und gibt diese zurück
        public Stammkunden ZuStammkundenMachen(int rabattInProzentZahl)
        {
            return(new Stammkunden(base.Name, base.Ort, base.PLZ, base.Straße, base.Hausnummer, rabattInProzentZahl, Kundennummer));
        }
        #endregion
    }
}
