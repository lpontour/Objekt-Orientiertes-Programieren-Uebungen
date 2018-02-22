using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arztpraxis
{
    class Test
    {
        void Run()
        {
            Praxis praxis = new Praxis("Praxis Kunterbunt");
            Terminal terminal = new Terminal();

            Arzt arzt = new Arzt("Jekyll", "Henry");

            Patient patient1 = new Patient("Müller", "Max", "01.01.1980");
            Patient patient2 = new Patient("Krüger", "Renate", "01.01.1980");
            Patient patient3 = new Patient("Fischer", "Klaus", "01.01.1980");
            Patient patient4 = new Patient("Schneider", "Marianne", "01.01.1980");
            Patient patient5 = new Patient("Schmidt", "Heinrich", "01.01.1980");
            Patient patient6 = new Patient("Weber", "Mathias", "01.01.1980");
            Patient patient7 = new Patient("Becker", "Peter", "01.01.1980");
            Patient patient8 = new Patient("Hoffmann", "Axel", "01.01.1980");
            Patient patient9 = new Patient("Bauer", "Karin", "01.01.1980");
            Patient patient10 = new Patient("Obama", "Barack", "01.01.1980");

            terminal.Anmelden(patient1);
            terminal.Anmelden(patient2);
            terminal.Anmelden(patient3);
            terminal.Behandeln();
            terminal.Anmelden(patient4);
            terminal.Anmelden(patient5);
            terminal.Anmelden(patient6);
            terminal.Behandeln();
            terminal.Anmelden(patient7);
            terminal.Anmelden(patient8);
            terminal.Anmelden(patient9);
            terminal.Behandeln();
            terminal.Anmelden(patient10);
        }
        static void Main(string[] args)
        {
            new Test().Run();
            Console.ReadKey();
        }
    }
}
