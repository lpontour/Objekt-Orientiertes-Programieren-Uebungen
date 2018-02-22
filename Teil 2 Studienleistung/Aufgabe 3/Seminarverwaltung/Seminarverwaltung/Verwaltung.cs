using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminarverwaltung
{
    class Verwaltung
    {
        #region field
        private Dictionary<int, Seminar> _seminare = new Dictionary<int, Seminar>();
        private Dictionary<int, Einzelpersonen> _einzelpersonen = new Dictionary<int, Einzelpersonen>();
        private Dictionary<int, Firma> _firmen = new Dictionary<int, Firma>();
        #endregion

        #region get/set
        public Dictionary<int, Firma> Firmen
        {
            get
            {
                return (_firmen);
            }
            set
            {
                _firmen = value;
            }
        }

        public Dictionary<int, Einzelpersonen> Einzelpersonen
        {
            get
            {
                return (_einzelpersonen);
            }
            set
            {
                _einzelpersonen = value;
            }
        }

        public Dictionary<int, Seminar> Seminare
        {
            get
            {
                return (_seminare);
            }
            set
            {
                _seminare = value;
            }
        }
        #endregion

        #region ctor

        #endregion

        #region methods
        //Erstellt ein Seminar
        public void SeminarErstellen(string kuerzel,string titel, string dozent, int maxAnmeldungen, double kosten, DateTime anfang, DateTime ende)
        {
            Seminare.Add(Seminar.LaufendeNr ,new Seminar(kuerzel, titel, dozent, maxAnmeldungen, kosten, anfang, ende));
        }

        //Meldet eine Firma bei einem Seminar an
        public void FirmaAnmelden(Seminar seminar, string telefonNr, string name, string ort, int plz, string hausnummer, string straße, string mail, string socialMedia, string AnsprechpartnerTelefonNr, string AnsprechpartnerName, string AnsprechpartnerOrt, int AnsprechpartnerPlz, string AnsprechpartnerHausnummer, string AnsprechpartnerStraße, string AnsprechpartnerMail, string AnsprechpartnerSocialMedia, string AnsprechpartnerAnrede, string AnsprechpartnerTitel, string AnsprechpartnerVorname, int anzahlTeilnehmer)
        {           
            seminar.FirmaAnmelden(new Firma(telefonNr, name, ort, plz, hausnummer, straße, mail, socialMedia, new Einzelpersonen(AnsprechpartnerTelefonNr, AnsprechpartnerName, AnsprechpartnerOrt, AnsprechpartnerPlz, AnsprechpartnerHausnummer, AnsprechpartnerStraße, AnsprechpartnerMail, AnsprechpartnerSocialMedia, AnsprechpartnerAnrede, AnsprechpartnerTitel, AnsprechpartnerVorname), anzahlTeilnehmer), "Anmeldung fuer: " + seminar.Titel);
            Console.WriteLine("Firma angemeldet");
        }

        //Meldet eine Einzelpersonen bei einem Seminar an
        public void EinzelpersonenAnmelden(Seminar seminar,string telefonNr, string name, string ort, int plz, string hausnummer, string straße, string mail, string socialMedia, string anrede, string titel, string vorname)
        {
            seminar.EinzelpersonenAnmelden(new Einzelpersonen(telefonNr, name, ort, plz, hausnummer, straße, mail, socialMedia, anrede, titel, vorname),"Anmeldung fuer: " + seminar.Titel);
            Console.WriteLine("Einzelperson angemeldet");
        }
        
        //Listet alle Seminar mit allen Teilnehmern auf
        public void SeminareListen()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Seminare:");
            Console.WriteLine("");
            foreach (Seminar Key in Seminare.Values)
            {
                Console.WriteLine("Titel:                " + Key.Titel);
                Console.WriteLine("Kürzel:               " + Key.Kuerzel);
                Console.WriteLine("SeminarNr:            " + Key.SeminatNr);
                Console.WriteLine("Dozent:               " + Key.Dozent);
                Console.WriteLine("Maximale Anmeldungen: " + Key.MaxAnmeldungen);
                Console.WriteLine("Preis pro Kopf:       " + Key.Kosten + " EUR");
                Console.WriteLine("Beginn:               " + Key.Anfang.ToShortDateString());
                Console.WriteLine("Ende:                 " + Key.Ende.ToShortDateString());
                Console.WriteLine("");

                if (Key.TeilnehmerFirmenListe.Count != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Firmen in Seminar " + Key.Titel);
                    Console.WriteLine("");

                    foreach (Firma Key2 in Key.TeilnehmerFirmenListe)
                    {
                        Console.WriteLine("Name:                           " + Key2.Name);
                        Console.WriteLine("Straße/Hausnummer:              " + Key2.Straße + " " + Key2.Hausnummer);
                        Console.WriteLine("Ort/PLZ:                        " + Key2.Ort + " " + Key2.PLZ);
                        Console.WriteLine("Telefonnummer:                  " + Key2.TelefonNr);
                        Console.WriteLine("Mail:                           " + Key2.Mail);
                        Console.WriteLine("Social Media:                   " + Key2.SocialMedia);
                        Console.WriteLine("Kundennummer:                   " + Key2.TeilnehmerNr);
                        Console.WriteLine("Anzahl Personen:                " + Key2.AnzahlTeilnehmer);
                        Console.WriteLine("Kosten:                         " + Key2.Rechnung.Betrag);
                        Console.WriteLine("MwSt:                           " + Key2.Rechnung.MwSt);
                        Console.WriteLine("Gesamtpreis:                    " + Key2.Rechnung.Gesamtbetrag);
                        Console.WriteLine("Rechnungsnummer:                " + Key2.Rechnung.Nummer);
                        Console.WriteLine("Anmeldungsbestaetigungstext:    " + Key2.Anmeldebestaetigung.FreiText);
                        Console.WriteLine("Anmeldungsbestaetigungsnummer : " + Key2.Anmeldebestaetigung.Buchungsnummer);
                        Console.WriteLine("");
                        Console.WriteLine("Ansprechpartner der Firma " + Key2.Name + ":");
                        Console.WriteLine("");
                        Console.WriteLine("Nachname:      " + Key2.Ansprechpartner.Name);
                        Console.WriteLine("Vorname:       " + Key2.Ansprechpartner.Vorname);
                        Console.WriteLine("Telefonnummer: " + Key2.Ansprechpartner.TelefonNr);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }

                if (Key.TeilnehmerEinzelpersonenListe.Count != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Einzelpersonen in " + Key.Titel + ":");
                    Console.WriteLine("");

                    foreach (Einzelpersonen Key3 in Key.TeilnehmerEinzelpersonenListe)
                    {
                        Console.WriteLine("Nachname:                       " + Key3.Name);
                        Console.WriteLine("Vorname:                        " + Key3.Vorname);
                        Console.WriteLine("Straße/Hausnummer:              " + Key3.Straße + " " + Key3.PLZ);
                        Console.WriteLine("Ort/PLZ:                        " + Key3.Ort + " " + Key3.PLZ);
                        Console.WriteLine("Telefonnummer:                  " + Key3.TelefonNr);
                        Console.WriteLine("Mail:                           " + Key3.Mail);
                        Console.WriteLine("Social Media:                   " + Key3.SocialMedia);
                        Console.WriteLine("Kundennummer:                   " + Key3.TeilnehmerNr);
                        Console.WriteLine("Kosten:                         " + Key3.Rechnung.Betrag);
                        Console.WriteLine("MwSt:                           " + Key3.Rechnung.MwSt);
                        Console.WriteLine("Gesamtpreis:                    " + Key3.Rechnung.Gesamtbetrag);
                        Console.WriteLine("Rechnungsnummer:                " + Key3.Rechnung.Nummer);
                        Console.WriteLine("Anmeldungsbestaetigungstext:    " + Key3.Anmeldebestaetigung.FreiText);
                        Console.WriteLine("Anmeldungsbestaetigungsnummer : " + Key3.Anmeldebestaetigung.Buchungsnummer);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
            }
        }

        //Listet alle Firmen auf
        public void FirmenListen()
        {
            if (Firmen.Count != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Firmen:");
                Console.WriteLine("");

                foreach (Firma Key in Firmen.Values)
                {
                    Console.WriteLine("Name:              " + Key.Name);
                    Console.WriteLine("Straße/Hausnummer: " + Key.Straße + " " + Key.Hausnummer);
                    Console.WriteLine("Ort/PLZ:           " + Key.Ort + " " + Key.PLZ);
                    Console.WriteLine("Telefonnummer:     " + Key.TelefonNr);
                    Console.WriteLine("Mail:              " + Key.Mail);
                    Console.WriteLine("Social Media:      " + Key.SocialMedia);
                    Console.WriteLine("Kundennummer:      " + Key.TeilnehmerNr);
                    Console.WriteLine("Anzahl Personen:   " + Key.AnzahlTeilnehmer);
                    Console.WriteLine("");
                    Console.WriteLine("Ansprechpartner der Firma " + Key.Name + ":");
                    Console.WriteLine("");
                    Console.WriteLine("Nachname:      " + Key.Ansprechpartner.Name);
                    Console.WriteLine("Vorname:       " + Key.Ansprechpartner.Vorname);
                    Console.WriteLine("Telefonnummer: " + Key.Ansprechpartner.TelefonNr);
                }
            }
        }

        //Listet alle Personen auf
        public void EinzelpersonenListen()
        {
            if (Einzelpersonen.Count != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Einzelpersonen:");
                Console.WriteLine("");

                foreach (Einzelpersonen Key in Einzelpersonen.Values)
                {
                    Console.WriteLine("Nachname:          " + Key.Name);
                    Console.WriteLine("Vorname:           " + Key.Vorname);
                    Console.WriteLine("Straße/Hausnummer: " + Key.Straße + " " + Key.PLZ);
                    Console.WriteLine("Ort/PLZ:           " + Key.Ort + " " + Key.PLZ);
                    Console.WriteLine("Telefonnummer:     " + Key.TelefonNr);
                    Console.WriteLine("Mail:              " + Key.Mail);
                    Console.WriteLine("Social Media:      " + Key.SocialMedia);
                    Console.WriteLine("Kundennummer:      " + Key.TeilnehmerNr);
                }
            }
        }
        #endregion
    }
}
