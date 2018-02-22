using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Stammkunden : Kunden
    {
        #region fields
        private int _rabattProzentZahl = 0;
        private int _kundennummer = 0;
        #endregion


        #region get/set
        public int RabattProzentZahl
        {
            get
            {
                return (_rabattProzentZahl);
            }
            set
            {
                _rabattProzentZahl = value;
            }
        }
        #endregion


        #region ctor
        public Stammkunden(string name, string ort, int plz, string straße, string hausnummer, int rabattProzentZahl, int kundennummer) : base(name, ort, plz, straße, hausnummer)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Stammkunde erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            _rabattProzentZahl = rabattProzentZahl;
            _kundennummer = kundennummer;
        }
        #endregion


        #region methods

        #endregion
    }
}
