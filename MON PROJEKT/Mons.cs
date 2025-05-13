using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{

    /*
    List<Mon> MonDex = new() - Liste oder Klasse mit Vererbung??
            {
                new Mon("Generic FireMon", MonType.Fire, 100, 80, 70, 60, 50, 80, 40, 90),
                new Mon("Generic WaterMon", MonTyp.Water, 50, 70, 50, 40, 90, 90, 90, 80),
                new Mon("Generic EarthMon", MonType.Earth, 120, 70, 90, 90, 40, 50, 50, 40),
                new Mon("Generic ToxinMon", MonType.Toxin, 90, 100, 60, 50, 60, 90, 60, 95),
                new Mon("Generic IceMon", MonType.Ice, 95, 85, 65, 55, 60, 85, 60, 88),
                new Mon("Generic LightningMon", MonType.Lightning, 50, 75, 70, 50, 60, 80, 60, 100),
                new Mon("Generic AirMon", MonType.Air, 100, 70, 80, 60, 80, 80, 50, 80),
                new Mon("Generic ShadowMon", MonType.Shadow, 40, 70, 30, 200, 80, 85, 40, 90),
                new Mon("Generic Biomon", MonType.Bio, 100, 85, 60, 65, 65, 70, 65, 75),
            };
    */

    // MONS

    // Eigenschaften der Mons:
    // mons haben NAME;
    // mons haben GENOS: THERIOID / SAUROID / AMPHIBIOID / ORNITHOID / ICHTHYOID / ASPONDYLOID / PHYTOID / ORGANOID;
    // mons haben MONTYPE: EARTH, BIO, TOXIN, WATER, ICE, FIRE, AIR, LIGHTNING, SHADOW;
    // (mons haben HOME BONUS -> erst im Kampfsystem)
    // mons haben SIMPLE GRAFIK und CRY (SpriteCry = string in Farbe und beep);
    // mons haben EXP-BAR (LevelExp = string Symbol in Farbe, Counter zum Level Up);
    // mons haben IMMER EINE KLASSE: STARTKLASSE "BASE";
    // mons haben ZUGANG ZU 3/5 KLASSEN: ("BASE" /) "FIGHTER" / "SPELLCASTER" / "ROGUE" / "MECHANIC" / "HEALER";
    // mons KÖNNEN KLASSE EINMALIG ÄNDERN (EINMALIGE AUSBILDUNG VON "BASE", ZUGANG NUR ZU JE 3 AUSBILDUNGEN)
    // mons haben JE 8 STATS: HP / STAMINA / PHY ATK / PHY DEF / PSYMINA / PSY ATK / PSY DEF / SPEED;
    // mons haben JE 4 ATTACKEN;
    // mons haben ATTACK LEARNSET;
    // mons haben GEWICHT: FEATHERWEIGHT / LIGHTWEIGHT / MIDDLEWEIGHT / HEAVYWEIGHT / SUPER HEAVYWEIGHT;
    // [ADDED AFTER GREEN LIGHT]:  Mons können zum HQ geschickt werden, wenn kein platz mehr in der Gang ist;

    // ALLE MON INFOS KÖNNEN ABGEFRAGT WERDEN!


    public abstract class Mon // abstrakte Klasse Mon
    {
        public string MonName { get; set; } // veränderbar, rechnerisch irrelevant
        public virtual void SpriteCry() // weil string+beep gemischt => METHODE! nicht veränderbar, rechnerisch irrelevant, nur "schön"
        {
            Console.WriteLine("MON"); // default ausgefüllt, um Format für mich zu wissen und nicht null zu bekommen
            Console.Beep(1000, 1000); // default ausgefüllt, um Format für mich zu wissen und nicht null zu bekommen
        }
        public Genos Genos { get; } // nicht veränderbar, rechnerisch irrelevant, nur "schön"
        public WeightClass WeightClass { get; } // nicht veränderbar, rechnerisch irrelevant, nur "schön"
        public List<MonType> MonTypes { get; } // nicht veränderbar, rechnerisch RELEVANT
        public int LevelExp { get; set; } // VERÄNDERBAR, rechnerisch RELEVANT
        public List<Klasse> Klassen { get; set; } // VERÄNDERBAR, rechnerisch RELEVANT
        public Dictionary<Stat, int> Stats { get; set; } = new Dictionary<Stat, int>// VERÄNDERBAR, rechnerisch RELEVANT
        {
                { Stat.HP, 50 }, // default ausgefüllt, um Format für mich zu wissen
    { Stat.Stamina, 50 },
    { Stat.PhyAtk, 50 },
    { Stat.PhyDef, 50 },
    { Stat.Psymina, 50 },
    { Stat.PsyAtk, 50 },
    { Stat.PsyDef, 50 },
    { Stat.Speed, 50 }
        };
        public List<Attacke> AttackenAktuell { get; set; } // VERÄNDERBAR, rechnerisch RELEVANT

        public List<Attacke> AttackenLearnset { get; set; } // nicht veränderbar, rechnerisch irrelevant

        protected Mon(string monName, Genos genos, WeightClass weightClass, List<MonType> monTypes, int levelExp, List<Klasse> klassen, Dictionary<Stat, int> stats, List<Attacke> attackenAktuell, List<Attacke> attackenLearnset)
        {
            MonName = monName;

            Genos = genos;
            WeightClass = weightClass;
            MonTypes = monTypes;
            LevelExp = levelExp;
            Klassen = klassen;
            Stats = stats;
            AttackenAktuell = attackenAktuell;
            AttackenLearnset = attackenLearnset;
        }



        public virtual void MonInfo()
        {
            Console.WriteLine($"Name: {MonName}");
            SpriteCry();
            Console.WriteLine($"Genos: {Genos}");
            Console.WriteLine($"Typen: {string.Join("", MonTypes)}"); // string.Join <= Listeninhalt als string ausgeben
            Console.WriteLine($"Klasse(n): {string.Join("", Klassen)}");
            Console.WriteLine($"Gewichtsklasse: {WeightClass}");
            Console.WriteLine($"Level: {LevelExp}");
            Console.WriteLine("Stats:");
            foreach (var stat in Stats) // var, weil verschiedene datentypen
                Console.WriteLine($"{stat.Key}: {stat.Value}"); // für jeden KEY den VALUE anzeigen -> KEY: HP, VALUE: 50
            Console.WriteLine("Attacken:");
            foreach (var atk in AttackenAktuell) // var, weil verschiedene datentypen
                Console.WriteLine($"{atk.AttackName} ({atk.AttackType} / {atk.AttackCategory} / Mina Cost: {atk.AttackCost})  - Power: {atk.Power}");
        }


    }


    // Enumeration optimal zur Auswahl von begrenzten Möglichkeiten


    public enum Genos
    {
        Therioid, Sauroid, Amphibioid, Ornithoid,
        Ichthyoid, Aspondyloid, Phytoid, Organoid
    }

    public enum WeightClass
    {
        Featherweight, Lightweight, Middleweight, Heavyweight, SuperHeavyweight
    }

    public enum MonType
    {
        Earth, Bio, Toxin, Water, Ice, Fire, Air, Lightning, Shadow
    }

    public enum Klasse
    {
        Base, Fighter, Spellcaster, Rogue, Mechanic, Healer
    }

    public enum Stat
    {
        HP, Stamina, PhyAtk, PhyDef, Psymina, PsyAtk, PsyDef, Speed
    }

    public enum AttackType
    {
        Earth, Bio, Toxin, Water, Ice, Fire, Air, Lightning, Shadow
    }

    public enum AttackCategory
    {
        Physical, Psychic, Status
    }

    // KLASSEN ETABLIERT ( WAS MÜSSEN OBJEKTE BEINHALTEN)
    // JETZT METHODEN (WAS MÜSSEN OBJEKTE KÖNNEN)!






    // QUELLEN: Unterrichtsmaterial/Übung zu Dictionary, Methoden, Klassen, Vererbung
}



