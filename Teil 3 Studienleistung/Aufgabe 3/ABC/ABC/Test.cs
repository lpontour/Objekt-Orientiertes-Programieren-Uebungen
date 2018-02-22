using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class Test
    {
        #region fields

        #endregion

        #region get/set

        #endregion

        #region ctor

        #endregion

        #region methods
        public void Run()
        {
            A a = new C(1.5);
            Console.WriteLine(a.X + " " + a.Y);            //Ausgabe 1

            int retA = a.F(1);
            Console.WriteLine(retA);                       //Ausgabe 2


            B b = new B(6); a = b; Console.WriteLine(b.X); // Ausgabe 3 
            Console.WriteLine( a.X + " " + a.Y );          // Ausgabe 4

            int retB = b.F(1f);
            Console.WriteLine(retB);                       // Ausgabe 5


            b.G(1.9);


            Console.WriteLine( a.X + " " + a.Y );          // Ausgabe 6
            int retAB = a.F(1);
            Console.WriteLine(retAB);                      // Ausgabe 7
        }

        static void Main(string[] args)
        {
            new Test().Run();
            Console.ReadKey();
        }
        #endregion
    }
}
