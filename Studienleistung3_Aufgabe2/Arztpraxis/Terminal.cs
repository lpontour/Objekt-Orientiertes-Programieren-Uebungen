using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class Terminal
    {
        #region fields
        // private Dictionary<int, Patient> _dictPatient;
        private SortedDictionary<int, Patient> _dictPatient;
        #endregion

        #region get/set

        #endregion

        #region ctor
        public Terminal()
        {
            // _dictPatient = new Dictionary<int, Patient>();
            _dictPatient = new SortedDictionary<int, Patient>();
        }
        #endregion

        #region methods
        public void Anmelden(Patient patient)
        {
            Console.WriteLine("Patient: {0}, {1}", patient.Nachname, patient.Vorname);
            this.PrintDict();
            Console.WriteLine("Möchten Sie in die Warteliste eingetragen werden?");
            char anmeldung = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (anmeldung == 'J' || anmeldung == 'j')
            {
                Console.WriteLine("Sie wurden eingetragen.");
                _dictPatient.Add(patient.PatientenNr, patient);
                patient.Angemeldet = true;
            }
            Console.WriteLine();
        }
        public void Abmelden(Patient patient)
        {
            _dictPatient.Remove(patient.PatientenNr);
        }
        public void NaechsterPatient()
        {
            int zaehler = _dictPatient.Keys.Min();
            Console.WriteLine("Nächster Patient: {0}, {1}", _dictPatient[zaehler].Nachname, _dictPatient[zaehler].Vorname);
            Console.WriteLine("Wartezeit: {0}", _dictPatient[zaehler].Wartezeit());
            Console.WriteLine("Anzahl weiterer Patienten: {0}", _dictPatient.Count-1);
        }
        public void PrintDict()
        {
            Console.WriteLine("---Warteliste um {0}", DateTime.Now.ToShortTimeString());
            if (_dictPatient.Count != 0)
            foreach(Patient patient in _dictPatient.Values)
            {
                Console.WriteLine("  {0}. {1:10} {2:10} {3}", patient.PatientenNr, patient.Nachname, patient.Vorname, patient.Anmeldezeit);
            }
            else
            {
                Console.WriteLine("Warteliste ist zur Zeit leer.");
            }
            Console.WriteLine();
        }
        public void Behandeln()
        {
            int zaehler = _dictPatient.Keys.Min();
            Console.WriteLine("Arzt behandelt gerade: {0}, {1} ", _dictPatient[zaehler].Nachname, _dictPatient[zaehler].Vorname);
            this.Abmelden(_dictPatient[zaehler]);
            this.PrintDict();
        }
        #endregion
    }
}
