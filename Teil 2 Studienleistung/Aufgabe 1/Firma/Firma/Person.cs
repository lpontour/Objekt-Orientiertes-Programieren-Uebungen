using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public abstract class Person
    {
        #region fields
        private string _name = "";
        private string _ort = "";
        private int _plz = 0;
        private string _straße = "";
        private string _hausnummer = "";
        #endregion


        #region get/set
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


        public string Straße
        {
            get
            {
                return (_straße);
            }
            set
            {
                _straße = value;
            }
        }


        public string Name
        {
            get
            {
                return(_name);
            }
            set
            {
               _name = value;
            }
        }


        public string Ort
        {
            get
            {
                return(_ort);
            }
            set
            {
                _ort = value;
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
        #endregion


        #region ctor
        public Person(string name, string ort, int plz, string straße, string hausnummer)
        {
            _name = name;
            _ort = ort;
            _plz = plz;
            _straße = straße;
            _hausnummer = hausnummer;
        }
        #endregion


        #region methods

        #endregion
    }
}
