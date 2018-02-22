using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
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
            Firma HP = new Firma("HP");
            HP.MitarbeiterHinzufuegen("Horst Zander", "Hannover", 29568, "Bergstraße", "5a", 1200.00);
            HP.MitarbeiterHinzufuegen("Bernd Forelle", "Bremen", 29128, "Blumenstraße", "36", 1200.00);
            HP.MitarbeiterHinzufuegen("Hector Lachs", "Steinhude", 45568, "Fensterstraße", "12", 1200.00);
            HP.MitarbeiterHinzufuegen("Werner Brösel", "Köln", 25578, "Flachweg", "3", 1200.00);
            HP.MitarbeiterHinzufuegen("Andy Brösel", "Uelzen", 75838, "Vogelstraße", "7b", 1200.00);
            HP.MitarbeiterHinzufuegen("Else Dorsch", "Langlingen", 2238, "Kabelweg", "8", 1200.00);
            HP.MitarbeiterHinzufuegen("Frederike Flunder", "Celle", 24548, "Sonnenallee", "3", 1200.00);
            HP.MitarbeiterHinzufuegen("Günther Fisch", "Lüneburg", 51168, "Brechstraße", "19", 1200.00);
            HP.MitarbeiterHinzufuegen("Fred Wald", "Oldenburg", 28521, "Holzstraße", "17", 1200.00);
            HP.MitarbeiterHinzufuegen("Bertram Brand", "Berlin", 23457, "Buschstraße", "21c", 1200.00);
            HP.MitarbeiterHinzufuegen("Ilse Baum", "Römstedt", 71235, "Amselsteg", "1", 1200.00);


            Console.WriteLine("Mitarbeiter Liste:");
            Console.WriteLine("");
            foreach (Mitarbeiter Key in HP.DicMitarbeiter.Values)
            {
                Console.WriteLine("Name:           " + Key.Name);
                Console.WriteLine("Wohnort:        " + Key.Ort + ", PLZ:          " + Key.PLZ);
                Console.WriteLine("Straße:         " + Key.Straße + ", Hausnummer:    " + Key.Hausnummer);
                Console.WriteLine("Personalnummer: " + Key.Personalnummer);
                Console.WriteLine("");
            }


            HP.MitarbeiterZuManagerMachen(HP.DicMitarbeiter[0], 500.00);

            HP.AbteilungErstellen("Verwaltung", HP.DicManager[0], HP.DicMitarbeiter[1]);

            HP.DicAbteilung[0].Mitarbeiter_einer_Abteilung_Hinzufuegen(HP.DicMitarbeiter[2]);

            Console.WriteLine("");
            Console.WriteLine("Manager Liste:");
            Console.WriteLine("");
            foreach (Manager Key in HP.DicManager.Values)
            {
                Console.WriteLine("Name:            " + Key.Name);
                Console.WriteLine("Wohnort:         " + Key.Ort + ", PLZ:                 " + Key.PLZ);
                Console.WriteLine("Straße:          " + Key.Straße + ", Hausnummer:       " + Key.Hausnummer);
                Console.WriteLine("Personalnummer:  " + Key.Personalnummer + ", Abteilung: " + Key.Abteilung.Bezeichnung);
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Abteilungen Liste:");
            Console.WriteLine("");

            HP.DicManager[0].Abteilung.Manager = HP.DicManager[0];

            foreach (Abteilung Key in HP.DicAbteilung.Values)
            {
                Console.WriteLine("Bezeichung:        " + Key.Bezeichnung);
                Console.WriteLine("Abteilungsnummer:  " + Key.Abteilungsnummer);
                Console.WriteLine("Manager:           " + Key.Manager.Name);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Mitarbeiter in Abteilung " + Key.Abteilungsnummer + ":");
                Console.WriteLine("");
                foreach (Mitarbeiter Key2 in Key.Mitarbeiteliste)
                {
                    Console.WriteLine("Mitarbeiter:     " + Key2.Name);
                    Console.WriteLine("Personalnummer:  " + Key2.Personalnummer);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            HP.MitarbeiterZuVertreterMachen(HP.DicMitarbeiter[4], "Braunschweig");
            HP.MitarbeiterZuVertreterMachen(HP.DicMitarbeiter[5], "Hannover");

            Console.WriteLine("");
            Console.WriteLine("Vertreter Liste:");
            Console.WriteLine("");
            foreach (Vertreter Key in HP.DicVertreter.Values)
            {
                Console.WriteLine("Name:            " + Key.Name);
                Console.WriteLine("Wohnort:         " + Key.Ort + ", PLZ:          " + Key.PLZ);
                Console.WriteLine("Straße:          " + Key.Straße + ", Hausnummer:    " + Key.Hausnummer);
                Console.WriteLine("Personalnummer:  " + Key.Personalnummer);
                Console.WriteLine("Vertriebsregion: " + Key.Vertriebsregion);
                Console.WriteLine();
            }

            HP.KundenHinzufuegen("Fred Pflaume", "Hannover", 71563, "Flussstraße", "12");
            HP.KundenHinzufuegen("Adolf Floß", "Bremen", 12365, "Kabelstraße", "5");
            HP.KundenHinzufuegen("Markus Fluss", "Köln", 78425, "Buschweg", "16");
            HP.KundenHinzufuegen("Richard Tuch", "Havekost", 29548, "Tischstraße", "17b");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Kunden Liste:");
            Console.WriteLine("");
            foreach (Kunden Key in HP.DicKunden.Values)
            {
                Console.WriteLine("Name:            " + Key.Name);
                Console.WriteLine("Wohnort:         " + Key.Ort + ", PLZ:          " + Key.PLZ);
                Console.WriteLine("Straße:          " + Key.Straße + ", Hausnummer:    " + Key.Hausnummer);
                Console.WriteLine("Personalnummer:  " + Key.Kundennummer);
                Console.WriteLine();
            }

            HP.StammKundenHinzufuegen(HP.DicKunden[0], 15);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Stammkunden Liste:");
            Console.WriteLine("");
            foreach (Stammkunden Key in HP.DicStammkunden.Values)
            {
                Console.WriteLine("Name:            " + Key.Name);
                Console.WriteLine("Wohnort:         " + Key.Ort + ", PLZ:          " + Key.PLZ);
                Console.WriteLine("Straße:          " + Key.Straße + ", Hausnummer:    " + Key.Hausnummer);
                Console.WriteLine("Personalnummer:  " + Key.Kundennummer);
                Console.WriteLine("Rabatt:          " + Key.RabattProzentZahl + "%");
                Console.WriteLine();
            }

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            new Test().Run();
        }
        #endregion
    }
}
