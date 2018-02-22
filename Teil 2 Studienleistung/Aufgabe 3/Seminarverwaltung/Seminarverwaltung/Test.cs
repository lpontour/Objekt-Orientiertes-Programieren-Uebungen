using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Test
    {
        #region field

        #endregion

        #region get/set

        #endregion

        #region ctor

        #endregion

        #region methods
        public void Run()
        {
            Verwaltung Hannover = new Verwaltung();
            Hannover.SeminarErstellen("UWS", "Umweltschutz", "Bernd Baum", 50, 12.50, new DateTime(2016, 05, 01), new DateTime(2016, 05, 29));
            Hannover.SeminarErstellen("WSK", "Wasserkraft", "Heinz Ghünter", 20, 7.00, new DateTime(2016, 04, 01), new DateTime(2016, 05, 25));

            Hannover.SeminareListen();

            Hannover.EinzelpersonenAnmelden(Hannover.Seminare[0], "01245/5151524125", "Stein", "Hannover", 25896, "6a", "Waldweg", "fredtstein@gwx.de", "FBName: Fredy Stein", "Herr", "Dr.", "Fred");
            Hannover.EinzelpersonenAnmelden(Hannover.Seminare[1], "01455/51545125", "Busch", "Hannover", 25896, "16", "Steinbruch", "horstbusch@gwx.de", "FBName: Horsty Busch", "Herr", "", "Horst");

            Hannover.SeminareListen();

            Hannover.FirmaAnmelden(Hannover.Seminare[0], "01514/54545115", "Clausco", "Hannover", 25896, "18", "Flussstraße", "clausco@gwx.de", "Website: Clausco.com", "01551/54151521", "Fass", "Hannover", 25896, "18c", "Fensterweg", "berndfass@gwx.de", "FBName: Berndo Fass", "Herr", "Dr.", "Bernd", 20);
            Hannover.FirmaAnmelden(Hannover.Seminare[0], "02514/5415", "Goofel", "Bremen", 32546, "36", "Zum Walde", "goofel@gwx.de", "Website: Goofel.com", "05251/5151521", "Rolle", "Bremen", 32546, "2", "Türstraße", "hectorrolle@gwx.de", "FBName: Hector Rollo", "Herr", "", "Hector", 10);

            Hannover.SeminareListen();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new Test().Run();
        }
        #endregion

    }
}
