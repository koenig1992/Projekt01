﻿using System;
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
        public virtual void SpriteCry() { }// weil string+beep gemischt => METHODE! nicht veränderbar, rechnerisch irrelevant, nur "schön"

        public Genos Genos { get; } // nicht veränderbar, rechnerisch irrelevant, nur "schön"
        public WeightClass WeightClass { get; } // nicht veränderbar, rechnerisch irrelevant, nur "schön"
        public MonAttackType MonType { get; } // nicht veränderbar, rechnerisch RELEVANT
        public int LevelExp { get; set; } // VERÄNDERBAR, rechnerisch RELEVANT
        public virtual MonKlasse KlasseAktuell { get; set; } // VERÄNDERBAR, rechnerisch RELEVANT
        public List<MonKlasse> KlassenOptionen { get; }
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

        protected Mon(string monName, Genos genos, WeightClass weightClass, MonAttackType monType, int levelExp, MonKlasse klasseAktuell, List<MonKlasse> klassenOptionen, Dictionary<Stat, int> stats, List<Attacke> attackenAktuell, List<Attacke> attackenLearnset)
        {
            MonName = monName;

            Genos = genos;
            WeightClass = weightClass;
            MonType = monType;
            LevelExp = levelExp;
            KlasseAktuell = klasseAktuell;
            KlassenOptionen = klassenOptionen;
            Stats = stats;
            AttackenAktuell = attackenAktuell;
            AttackenLearnset = attackenLearnset;
        }



        public virtual void MonInfo()
        {
            Console.WriteLine($"Name: {MonName}");
            SpriteCry();
            Console.WriteLine($"Genos: {Genos}");
            Console.WriteLine($"Typen: {string.Join("", MonType)}"); // string.Join <= Listeninhalt als string ausgeben
            Console.WriteLine($"Klasse(n): {string.Join("", KlasseAktuell)}");
            Console.WriteLine($"Gewichtsklasse: {WeightClass}");
            Console.WriteLine($"Level: {LevelExp}");
            Console.WriteLine("Stats:");
            foreach (var stat in Stats) // var, weil verschiedene datentypen
                Console.WriteLine($"{stat.Key}: {stat.Value}"); // für jeden KEY den VALUE anzeigen -> KEY: HP, VALUE: 50
            Console.WriteLine("Attacken:");
            foreach (var atk in AttackenAktuell) // var, weil verschiedene datentypen
                Console.WriteLine($"{atk.AttackName} ({atk.AttackType} / {atk.AttackCategory} / Mina Cost: {atk.AttackCost})  - Power: {atk.Power}");
        }

        public virtual void WechselKlasse()
        {



            if (!(KlasseAktuell == MonKlasse.BASE))
            {
                Console.WriteLine($"{MonName} ist bereits {KlasseAktuell} – Klassenwechsel nicht möglich");
                return;
            }

            Console.WriteLine($"{MonName} kann eine Ausbildung zu einer der folgenden Klassen beginnen:\n" +
                $"{string.Join("\n", KlassenOptionen)}" +
                $"\nBitte wähle eine der angezeigten Klassen aus\n");

            string eingabeAusbildung = Console.ReadLine()?.Trim().ToUpper() ?? "";
            bool ausbildungMoeglich = Enum.TryParse<MonKlasse>(eingabeAusbildung, true, out var ausbildung) && KlassenOptionen.Contains(ausbildung);
            if (!ausbildungMoeglich)
            {
                Console.WriteLine($"{MonName} kann diese Ausbildung nicht machen");
            }

            if (ausbildungMoeglich)
            {
                switch (ausbildung)
                {

                    case MonKlasse.FIGHTER:
                        Console.WriteLine($"{MonName} macht eine Ausbildung zum FIGHTER!");
                        KlasseAktuell = MonKlasse.FIGHTER;

                        SpriteCry();
                        Console.ReadLine();
                        Stats[Stat.HP] += 30;
                        Stats[Stat.Stamina] += 40;
                        Stats[Stat.PhyAtk] += 40;
                        Stats[Stat.PhyDef] += 40;
                        Console.WriteLine("HP +30\nStamina +40\nPhyAtk +40\nPhyDef +40");
                        Console.ReadLine();
                        foreach (var stat in Stats)
                            Console.WriteLine($"{stat.Key}: {stat.Value}");

                        Console.ReadLine();
                        break;

                    case MonKlasse.SPELLCASTER:
                        Console.WriteLine($"{MonName} macht eine Ausbildung zum SPELLCASTER!");
                        KlasseAktuell = MonKlasse.SPELLCASTER;
                        SpriteCry();
                        Console.ReadLine();
                        Stats[Stat.HP] += 30;
                        Stats[Stat.Psymina] += 40;
                        Stats[Stat.PsyAtk] += 40;
                        Stats[Stat.PsyDef] += 40;
                        Console.WriteLine("HP +30\nPsymina +40\nPsyAtk +40\nPsyDef +40");
                        Console.ReadLine();
                        foreach (var stat in Stats)
                            Console.WriteLine($"{stat.Key}: {stat.Value}");

                        Console.ReadLine();
                        break;

                    case MonKlasse.ROGUE:
                        Console.WriteLine($"{MonName} macht eine Ausbildung zum ROGUE!");
                        KlasseAktuell = MonKlasse.ROGUE;
                        SpriteCry();
                        Console.ReadLine();
                        Stats[Stat.Speed] += 60;
                        Stats[Stat.Stamina] += 20;
                        Stats[Stat.PhyAtk] += 20;
                        Stats[Stat.Psymina] += 20;
                        Stats[Stat.PsyAtk] += 20;
                        Console.WriteLine("Speed +60\nStamina +20\nPhyAtk +20\nPsymina +20\nPsyAtk +20");
                        Console.ReadLine();
                        foreach (var stat in Stats)
                            Console.WriteLine($"{stat.Key}: {stat.Value}");

                        Console.ReadLine();
                        break;

                    case MonKlasse.MECHANIC:
                        Console.WriteLine($"{MonName} macht eine Ausbildung zum MECHANIC!");
                        KlasseAktuell = MonKlasse.MECHANIC;
                        SpriteCry();
                        Console.ReadLine();
                        Stats[Stat.HP] += 20;
                        Stats[Stat.Stamina] += 30;
                        Stats[Stat.PhyDef] += 30;
                        Stats[Stat.Psymina] += 30;
                        Stats[Stat.PsyDef] += 30;
                        Console.WriteLine("HP +20\nStamina +30\nPhyDef +30\nPsymina +30\nPsyDef +30");
                        Console.ReadLine();
                        foreach (var stat in Stats)
                            Console.WriteLine($"{stat.Key}: {stat.Value}");

                        Console.ReadLine();
                        break;

                    case MonKlasse.HEALER:
                        Console.WriteLine($"{MonName} macht eine Ausbildung zum HEALER!");
                        KlasseAktuell = MonKlasse.HEALER;
                        SpriteCry();
                        Console.ReadLine();
                        Stats[Stat.HP] += 20;
                        Stats[Stat.Stamina] += 50;
                        Stats[Stat.Psymina] += 50;
                        Stats[Stat.Speed] += 20;
                        Console.WriteLine("HP +20\nStamina +50\nPsymina +50\nSpeed +20");
                        Console.ReadLine();
                        foreach (var stat in Stats)
                            Console.WriteLine($"{stat.Key}: {stat.Value}");

                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Ungültige Eingabe. Kein Klassenwechsel durchgeführt");
                        Console.ReadLine();
                        break;

                }
            }



            /*


            // HIER WAHRSCHEINLICH ÜBERSCHREIBEN GUT
            // KlasseAktuell = neueKlasse;
            // Console.WriteLine($"{MonName} wurde zu einem {neueKlasse}!");
            */

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

    public enum MonAttackType
    {
        Earth, Bio, Toxin, Water, Ice, Fire, Air, Lightning, Shadow
    }

    public enum MonKlasse
    {
        BASE, FIGHTER, SPELLCASTER, ROGUE, MECHANIC, HEALER
    }

    public enum Stat
    {
        HP, Stamina, PhyAtk, PhyDef, Psymina, PsyAtk, PsyDef, Speed
    }

    public enum AttackCategory
    {
        Physical, Psychic, Status
    }
}

// KLASSEN ETABLIERT ( WAS MÜSSEN OBJEKTE BEINHALTEN)
// JETZT METHODEN (WAS MÜSSEN OBJEKTE KÖNNEN)!






// QUELLEN: Unterrichtsmaterial/Übung zu Dictionary, Methoden, Klassen, Vererbung




