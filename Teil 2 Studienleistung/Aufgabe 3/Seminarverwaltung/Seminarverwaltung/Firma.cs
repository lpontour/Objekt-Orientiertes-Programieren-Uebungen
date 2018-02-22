using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Firma : Teilnehmer
    {
        #region field
        private Einzelpersonen _ansprechpartner;
        private int _anzahlTeilnehmer = 0;
        private int _teilnehmerNr = 0;
        #endregion

        #region get/set
        public int TeilnehmerNr
        {
            get
            {
                return (_teilnehmerNr);
            }
            set
            {
                _teilnehmerNr = value;
            }
        }

        public Einzelpersonen Ansprechpartner
        {
            get
            {
                return (_ansprechpartner);
            }
            set
            {
                _ansprechpartner = value;
            }
        }

        public int AnzahlTeilnehmer
        {
            get
            {
                return (_anzahlTeilnehmer);
            }
            set
            {
                _anzahlTeilnehmer = value;
            }
        }
        #endregion

        #region ctor
        public Firma(string telefonNr, string name, string ort, int plz, string hausnummer, string straße, string mail, string socialMedia, Einzelpersonen ansprechpartner, int anzahlTeilnehmer) : base(telefonNr, name, ort, plz, hausnummer, straße, mail, socialMedia)
        {
            Ansprechpartner = ansprechpartner;
            AnzahlTeilnehmer = anzahlTeilnehmer;
            TeilnehmerNr = LaufendeNr;
            LaufendeNr++;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Firma erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        #endregion

        #region methods

        #endregion
    }
}
