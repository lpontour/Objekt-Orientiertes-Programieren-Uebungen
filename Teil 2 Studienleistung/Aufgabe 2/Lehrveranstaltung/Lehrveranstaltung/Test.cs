using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrveranstaltung
{
    class Test
    {
        //Wichtig!!!! DateTime's müssen angepasst werden Zeiträume arbeiten mit DateTime.Now aber nur wenn der Kontrollzeitraum über den 25.5.2016 geht
        #region fields

        #endregion


        #region get/set

        #endregion


        #region ctor

        #endregion


        #region methods
        public void Run()
        {
            Verwaltung Hannover = new Verwaltung();
            Hannover.NeueLVA("Office Basic's", new DateTime(2016, 05, 01), new DateTime(2016, 05, 30));
            Hannover.NeueLVA("Moderation", new DateTime(2016, 05, 01), new DateTime(2016, 08, 25));

            Hannover.LVAListe();

            Hannover.Studentanlegen("Horst Ghünter");
            Hannover.Studentanlegen("Fred Tür");

            Hannover.StudentenListen();

            Hannover.StudentBeiVeranstalungAnmelden(Hannover.StudentenDic[0], Hannover.VeranstaltungsDic[0]);
            Hannover.StudentBeiVeranstalungAnmelden(Hannover.StudentenDic[1], Hannover.VeranstaltungsDic[1]);

            Hannover.LVAListe();
            Hannover.StudentenListen();

            Hannover.LVALöschen(Hannover.VeranstaltungsDic[0].LVANummer);

            Hannover.LVAListe();

            Hannover.StudentBeiVeranstalungAnmelden(Hannover.StudentenDic[0], Hannover.VeranstaltungsDic[1]);

            Hannover.LVAListe();
            Hannover.StudentenListen();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new Test().Run();
        }
        #endregion
    }
}
