using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Anmeldebestaetigung
    {
        #region field
        private DateTime _datum;
        private int _buchungsnummer = 0;
        private static int _laufendeNr = 0;
        private string _freiText = "";
        #endregion

        #region get/set
        public string FreiText
        {
            get
            {
                return (_freiText);
            }
            set
            {
                _freiText = value;
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

        public DateTime Datum
        {
            get
            {
                return (_datum);
            }
            set
            {
                _datum = value;
            }
        }

        public int Buchungsnummer
        {
            get
            {
                return (_buchungsnummer);
            }
            set
            {
                _buchungsnummer = value;
            }
        }
        #endregion

        #region ctor
        public Anmeldebestaetigung(string freitext)
        {
            FreiText = freitext;
            Buchungsnummer = LaufendeNr;
            Datum = DateTime.Now;
            LaufendeNr++;
            Console.WriteLine("Anmeldebestätigung erstellt");
        }
        #endregion

        #region methodes

        #endregion
    }
}
