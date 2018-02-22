using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
     abstract class Teilnehmer
    {
        #region field
        private string _straße = "";
        private string _hausnummer = "";
        private int _plz = 0;
        private static int _laufendeNr = 0;
        private string _ort = "";
        private string _name = "";
        private string _telefonNr = "";
        private string _mail = "";
        private string _socialmedia = "";
        private Anmeldebestaetigung _anmeldebestaetigung;
        private Rechnung _rechnung;
        #endregion

        #region get/set
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

        public Rechnung Rechnung
        {
            get
            {
                return (_rechnung);
            }
            set
            {
                _rechnung = value;
            }
        }

        public Anmeldebestaetigung Anmeldebestaetigung
        {
            get
            {
                return (_anmeldebestaetigung);
            }
            set
            {
                _anmeldebestaetigung = value;
            }
        }

        public string SocialMedia
        {
            get
            {
                return (_socialmedia);
            }
            set
            {
                _socialmedia = value;
            }
        }

        public string Mail
        {
            get
            {
                return (_mail);
            }
            set
            {
                _mail = value;
            }
        }

        public string Straße
        {
            get
            {
                return(_straße);
            }
            set
            {
                _straße = value;
            }
        }

        public string Hausnummer
        {
            get
            {
                return (_hausnummer);
            }
            set
            {
                _hausnummer = value;
            }
        }

        public int PLZ
        {
            get
            {
                return (_plz);
            }
            set
            {
                _plz = value;
            }
        }

        public string Ort
        {
            get
            {
                return (_ort);
            }
            set
            {
                _ort = value;
            }
        }

        public string Name
        {
            get
            {
                return (_name);
            }
            set
            {
                _name = value;
            }
        }

        public string TelefonNr
        {
            get
            {
                return (_telefonNr);
            }
            set
            {
                _telefonNr = value;
            }
        }
        #endregion

        #region ctor
        public Teilnehmer(string telefonNr, string name, string ort, int plz, string hausnummer, string straße, string mail, string socialMedia)
        {
            TelefonNr = telefonNr;
            Name = name;
            Ort = ort;
            PLZ = plz;
            Hausnummer = hausnummer;
            Straße = straße;
            Mail = mail;
            SocialMedia = socialMedia;
        }
        #endregion

        #region methods

        #endregion
    }
}
