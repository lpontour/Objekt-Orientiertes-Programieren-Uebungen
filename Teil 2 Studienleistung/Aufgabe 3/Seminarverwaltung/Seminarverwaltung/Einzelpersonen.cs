using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Einzelpersonen : Teilnehmer
    {
        #region field
        private string _anrede = "";
        private string _titel = "";
        private string _vorname = "";
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

        public string Vorname
        {
            get
            {
                return(_vorname);
            }
            set
            {
                _vorname = value;
            }
        }

        public string Anrede
        {
            get
            {
                return(_anrede);
            }
            set
            {
                _anrede = value;
            }
        }

        public string Titel
        {
            get
            {
                return(_titel);
            }
            set
            {
                _titel = value;
            }
        }
        #endregion

        #region ctor
        public Einzelpersonen(string telefonNr, string name, string ort, int plz, string hausnummer, string straße, string mail, string socialMedia, string anrede, string titel, string vorname) : base(telefonNr, name, ort, plz, hausnummer, straße, mail, socialMedia)
        {
            Anrede = anrede;
            Titel = titel;
            Vorname = vorname;
            TeilnehmerNr = LaufendeNr;
            LaufendeNr++;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Einzelperson erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        #endregion

        #region methods

        #endregion
    }
}
