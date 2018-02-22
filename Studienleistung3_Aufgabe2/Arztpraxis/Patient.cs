using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class Patient : Person
    {
        #region fields
        private string _geburtsdatum;
        private bool _angemeldet;
        private DateTime _anmeldezeit;
        private int _patientenNr;
        private static int lfdNr = 1;
        #endregion

        #region get/set
        public bool Angemeldet
        {
            get { return _angemeldet; }
            set { _angemeldet = value; }
        }
        public DateTime Anmeldezeit
        {
            get { return _anmeldezeit; }
        }
        public int PatientenNr
        {
            get { return _patientenNr; }
        }
        #endregion

        #region ctor
        public Patient(string nachname, string vorname, string geburtsdatum) : base(nachname, vorname)
        {
            _geburtsdatum = geburtsdatum;
            _patientenNr = lfdNr;
            _anmeldezeit = DateTime.Now;
            lfdNr++;
            _angemeldet = false;
        }
        #endregion

        #region methods
        public string Wartezeit()
        {
            TimeSpan wartezeitSpan = DateTime.Now - Anmeldezeit;
            string wartezeit = wartezeitSpan.Hours.ToString() + wartezeitSpan.Minutes.ToString();
            return wartezeit;
        }
        #endregion
    }

}