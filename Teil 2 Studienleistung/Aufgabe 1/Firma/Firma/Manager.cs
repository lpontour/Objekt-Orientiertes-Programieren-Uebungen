using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Manager : Mitarbeiter
    {
        #region fields
        private double _bonus = 0.0;
        private Abteilung _abteilung = null;
        private int _personalnummer = 0;
        #endregion


        #region get/set
        public Abteilung Abteilung
        {
            get
            {
                return (_abteilung);
            }
            set
            {
                _abteilung = value;
            }
        }


        public double Bonus
        {
            get
            {
                return (_bonus);
            }
            set
            {
                _bonus = value;
            }
        }
        #endregion


        #region ctor
        public Manager(string name, string ort, int plz, string straße, string hausnummer, int personalnummer, double gehalt, double bonus, params Abteilung[] abteilung) : base(name, ort, plz, straße, hausnummer, gehalt)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Mitarbeiter zu Manager gemacht");
            Console.WriteLine("");
            Console.WriteLine("");
            _bonus = bonus;
            _personalnummer = personalnummer;
            //try/catch Block um die nullArgumentException bei eine´m leeren param array abzufangen
            try
            {
                _abteilung = abteilung[0];
            }
            catch
            {
                //mir ist ehrlich gesagt nich eingefallen was ich dann tuhen soll ?
            }
        }
        #endregion
    }
}
