using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MON_PROJEKT
{           /*
    internal class Klassen
    {

    // KLASSENWECHSEL BENÖTIGT:
    //        Aktuelle Klasse (default: Base)
    //        Neue Klasse
    //        KlassenOptionen
    //        Spieler wählt eine von 3 möglichen Optionen

        public void WechselKlasse(Klasse neueKlasse)
        {
            if (AktuelleKlasse != Klasse.Base)
            {
                Console.WriteLine($"{Name} ist bereits {AktuelleKlasse} – Klassenwechsel nicht möglich.");
                return;
            }

            if (!KlassenOptionen.Contains(neueKlasse))
            {
                Console.WriteLine($"{Name} kann die Klasse {neueKlasse} nicht annehmen.");
                return;
            }

            AktuelleKlasse = neueKlasse;
            Console.WriteLine($"{Name} wurde zu einem {neueKlasse}!");

            switch (neueKlasse)
            {
                case Klasse.Fighter:
                    Console.WriteLine("FGHT");
                    Stats["HP"] += 30;
                    Stats["Stamina"] += 40;
                    Stats["PhyAtk"] += 40;
                    Stats["PhyDef"] += 40;
                    break;
                   

                case Klasse.Spellcaster:
                    Console.WriteLine("SPLL");
                    Stats["HP"] += 30;
                    Stats["Psymina"] += 40;
                    Stats["PsyAtk"] += 40;
                    Stats["PsyDef"] += 40;
                    break;


                case Klasse.Rogue:
                    Console.WriteLine("ROG");
                    Stats["Speed"] += 60;
                    Stats["Stamina"] += 20;
                    Stats["PhyAtk"] += 20;
                    Stats["Psymina"] += 20;
                    Stats["PsyAtk"] += 20;
                    break;

                case Klasse.Mechanic:
                    Console.WriteLine("MECH");
                    Stats["HP"] += 20;
                    Stats["Stamina"] += 30; 
                    Stats["PhyDef"] += 30;
                    Stats["Psymina"] += 30;
                    Stats["PsyDef"] += 30;
                    break;

                case Klasse.Healer:
                    Console.WriteLine("HEAL");
                    Stats["HP"] += 20;
                    Stats["Stamina"] += 50;
                    Stats["Psymina"] += 50;
                    Stats["Speed"] += 20;
                    break;
    
        // EVTL BESSER: OVERRIDE, WEIL WERTE WIE HP UND MINA NEUES, PERMANENTES MAX BEKOMMEN, IM KAMPF WERTE ABER TEMPORÄR VERRINGERT WERDEN KÖNNEN
        // NEUES MAX != AKTUELLER WERT
        // ODER EVTL BESSER: CALL BY VALUE / CALL BY REFERENCE

            }
        }
    } */
}
