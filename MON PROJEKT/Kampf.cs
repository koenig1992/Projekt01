using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
    public abstract class Kampf
    {
        public abstract bool StartKampf();

    }


    public class EasyKampf : Kampf
    {
        public override bool StartKampf()
        {
            Console.WriteLine("eeeeeeasy fight");
            Console.WriteLine("ja, hier sollte jetzt der kampf sein");


            return true; // platzhalter: sieg
        }
    }

    public class MidKampf : Kampf
    {
        public override bool StartKampf()
        {
            Console.WriteLine("medium fighty shmighty");
            Console.WriteLine("ja, hier sollte jetzt der kampf sein");

            return true;
        }
    }

    public class HardKampf : Kampf
    {
        public override bool StartKampf()
        {
            Console.WriteLine("hard fight");
            Console.WriteLine("ja, hier sollte jetzt der kampf sein");

            return true;
        }
    }

    public class BossKampf : Kampf
    {
        public override bool StartKampf()
        {
            Console.WriteLine("BOSS TIME BRUDIIIII");
            Console.WriteLine("ja, hier sollte jetzt der kampf sein");

            return true;
        }
    }


    public static class GegnerLogik
    {
        public static List<Mon> ComputerGegner(Mon[] pool) // TAUSEND VERSIONEN VERSUCHT, NICHT SELBST HINBEKOMMEN!!!
        {
            Random rnd = new();
            List<Mon> poolList = pool.ToList(); // .ToList() - liste benutzen, hätte ich ohne GPT nicht gefunden
            List<Mon> team = new();

            int anzahl = 0;
            while (anzahl < 3)
            {
                int zufall = rnd.Next(poolList.Count); // randomizer
                Mon ausgewaehlt = poolList[zufall];    // mon auswählen
                team.Add(ausgewaehlt);                 // .Add() - zu team hinzufügen
                poolList.RemoveAt(zufall);             // .Remove() - aus pool entfernen
                anzahl++;
            }

            Console.WriteLine("Gegnerteam wurde ausgewählt:");
            foreach (var mon in team)
            {
                Console.WriteLine($"- {mon.MonName} (Typ: {mon.MonType}");
            }

            return team;
        }

    }



    public static class TypenEffektivitaet // übernommen, aber umformuliert aus meinem eigenen vorherigen projekt
                                           // update: wahrscheinlich keine zeit für implementierung :(
    {
        private static Dictionary<MonAttackType, List<MonAttackType>> Effektiv = new()
    {
        { MonAttackType.Fire, new List<MonAttackType> { MonAttackType.Bio, MonAttackType.Ice, MonAttackType.Toxin } },
        { MonAttackType.Water, new List<MonAttackType> { MonAttackType.Fire, MonAttackType.Lightning, MonAttackType.Earth } },
        { MonAttackType.Earth, new List<MonAttackType> { MonAttackType.Lightning, MonAttackType.Ice, MonAttackType.Fire } },
        { MonAttackType.Air, new List<MonAttackType> { MonAttackType.Fire, MonAttackType.Bio } },
        { MonAttackType.Lightning, new List<MonAttackType> { MonAttackType.Water, MonAttackType.Air, MonAttackType.Shadow } },
        { MonAttackType.Bio, new List<MonAttackType> { MonAttackType.Earth, MonAttackType.Water } },
        { MonAttackType.Toxin, new List<MonAttackType> { MonAttackType.Bio, MonAttackType.Water } },
        { MonAttackType.Ice, new List<MonAttackType> { MonAttackType.Water, MonAttackType.Earth } },
        { MonAttackType.Shadow, new List<MonAttackType> { MonAttackType.Shadow, MonAttackType.Bio } },
    };

        private static Dictionary<MonAttackType, List<MonAttackType>> Immunitaet = new()
    {
        { MonAttackType.Air, new List<MonAttackType> { MonAttackType.Earth } },
        { MonAttackType.Earth, new List<MonAttackType> { MonAttackType.Lightning } },
    };
    }
}

