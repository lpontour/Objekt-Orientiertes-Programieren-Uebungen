using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrveranstaltung
{
    class Student
    {
        #region fields
        private string _name = "";
        private int _matrikelNr = 0;
        private static int _laufendeNummer = 0;
        #endregion


        #region get/set

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

        public static int LaufendeNummer
        {
            get
            {
                return (_laufendeNummer);
            }
            set
            {
                _laufendeNummer = value;
            }
        }

        public int MatrikelNr
        {
            get
            {
                return (_matrikelNr);
            }
            set
            {
                _matrikelNr = value;
            }
        }
        #endregion


        #region ctor
        public Student(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Student erstellt");
            Console.WriteLine("");
            Console.WriteLine("");
            Name = name;
            MatrikelNr = LaufendeNummer;
            LaufendeNummer++;
        }
        #endregion


        #region methods

        #endregion
    }
}
