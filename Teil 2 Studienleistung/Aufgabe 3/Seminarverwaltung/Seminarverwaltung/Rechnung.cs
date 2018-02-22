using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Rechnung
    {
        #region field
        private int _nummer = 0;
        private static int _laufendeNr = 0;
        private double _betrag = 0.0;
        private double _mwSt = 0.0;
        private double _gesamtbetrag = 0.0;
        private DateTime _datum;
        #endregion

        #region get/set
        public double Gesamtbetrag
        {
            get
            {
                return (_gesamtbetrag);
            }
            set
            {
                _gesamtbetrag = value;
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

        public double Betrag
        {
            get
            {
                return (_betrag);
            }
            set
            {
                _betrag = value;
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

        public int Nummer
        {
            get
            {
                return (_nummer);
            }
            set
            {
                _nummer = value;
            }
        }
        #endregion

        #region ctor
        public Rechnung(double betrag, double mwSt)
        {
            Datum = DateTime.Now;
            Betrag = betrag;
            MwSt = mwSt;
            Gesamtbetrag = (Betrag + ((mwSt / 10) * Betrag));
            Nummer = LaufendeNr;
            LaufendeNr++;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Rechnung erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        #endregion

        #region methodes

        #endregion
    }
}
