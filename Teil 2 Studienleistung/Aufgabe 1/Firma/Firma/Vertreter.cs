using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Vertreter : Mitarbeiter
    {
        #region fields
        private string _vertriebsregion = "";
        private int _personalnummer = 0;
        #endregion


        #region get/set
        public string Vertriebsregion
        {
            get
            {
                return (_vertriebsregion);
            }
            set
            {
                _vertriebsregion = value;
            }
        }
        #endregion


        #region ctor
        public Vertreter(string name, string ort, int plz, string straße, string hausnummer, int personalnummer, double gehalt, string vertriebsregion) : base (name, ort, plz, straße, hausnummer, gehalt)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Vertreter erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            _vertriebsregion = vertriebsregion;
            _personalnummer = personalnummer;
        }
        #endregion


        #region methods

        #endregion
    }
}
