using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class Person
    {
        #region fields
        private string _nachname;
        private string _vorname;
        #endregion

        #region get/set
        public string Nachname
        {
            get { return _nachname; }
        }
        public string Vorname
        {
            get { return _vorname; }
        }

        #endregion

        #region ctor
        public Person(string nachname, string vorname)
        {
            _nachname = nachname;
            _vorname = vorname;
        }
        #endregion

        #region methods

        #endregion
    }
}
