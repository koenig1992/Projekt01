using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MON_PROJEKT
{

    public abstract class Area
    {
        public string AreaName { get; set; } // UMBENENNEN WENN AREA ABGESCHLOSSEN; DESHALB AUCH SET
        public bool BossBesiegt { get; set; }

        public bool AreaConquered { get; set; }

        public string AreaDescription { get; }

        public List<Mon> EasyAreaMon { get; set; }

        public List<Mon> MidAreaMon { get; set; }

        public List<Mon> HardAreaMon { get; set; }

        public List<Mon> BossAreaMon { get; set; }

        public string HomeBonusType { get; }

        protected Area(string areaName, bool bossBesiegt, bool areaConquered, string areaDescription, List<Mon> easyAreaMon, List<Mon> midAreaMon, List<Mon> hardAreaMon, List<Mon> bossAreaMon, string homeBonusType)
        {
            AreaName = areaName;
            BossBesiegt = false;
            AreaConquered = false;
            AreaDescription = areaDescription;
            EasyAreaMon = new List<Mon>();
            MidAreaMon = new List<Mon>();
            HardAreaMon = new List<Mon>();
            BossAreaMon = new List<Mon>();

        }



        public virtual void EnterArea() // <== METHODE, WEIL WAS MUSS AREA KÖNNEN. VIRTUAL METHODE, DAMIT ICH SPÄTER OVERRIDE VERWENDEN KANN
        {
            // Console.WriteLine($"Now entering {AreaName}...");
            // Console.WriteLine($"{Music.MusicDesert}");
        }

        public virtual void EnterMusic() // <== METHODE, WEIL WAS MUSS AREA KÖNNEN. VIRTUAL METHODE, DAMIT ICH SPÄTER OVERRIDE VERWENDEN KANN
        {

        }

        public virtual void EasyArea()
        {
            Console.WriteLine($"EasyArea: {AreaName} 3 Kämpfe und 3 Siege gegen RANDOM GANGs hier, dann Weiter zu MidArea");
            Console.ReadLine();


            Kampf easyF = new EasyKampf();
            bool areaConquered = false;
            int wins = 0;


            while (wins < 3)
            {
                bool win = easyF.StartKampf();

                if (win)
                {
                    wins++;
                }
                else
                {
                    Console.WriteLine("We Got Fucked!\nTactical Retreat!\nBack to the HQ");
                    return;
                }


            }

            if (wins == 3)
            {
                areaConquered = true;
                Console.WriteLine($"{AreaName} EasyArea Conquered!\nMoving On!");
            }

        }

        public virtual void MidArea()
        {
            Console.WriteLine($"MidArea {AreaName}: 3 Kämpfe und 3 Siege gegen RANDOM GANGs hier, dann Weiter zu HardArea");
            Console.ReadLine();

            Kampf midF = new MidKampf();
            bool areaConquered = false;
            int wins = 0;


            while (wins < 3)
            {
                bool win = midF.StartKampf();

                if (win)
                {
                    wins++;
                }
                else
                {
                    Console.WriteLine("We Got Fucked!\nTactical Retreat!\nBack to the HQ");
                    return;
                }


            }

            if (wins == 3)
            {
                areaConquered = true;
                Console.WriteLine($"{AreaName} MidArea Conquered!\nMoving On!");
            }

        }

        public virtual void HardArea()
        {
            Console.WriteLine($"HardArea: {AreaName} 3 Kämpfe und 3 Siege gegen RANDOM GANGs hier, dann Weiter zu BossArea");
            Console.ReadLine();

            Kampf hardF = new HardKampf();
            bool areaConquered = false;
            int wins = 0;


            while (wins < 3)
            {
                bool win = hardF.StartKampf();

                if (win)
                {
                    wins++;
                }
                else
                {
                    Console.WriteLine("We Got Fucked!\nTactical Retreat!\nBack to the HQ");
                    return;
                }


            }

            if (wins == 3)
            {
                areaConquered = true;
                Console.WriteLine($"{AreaName} HardArea Conquered!\nMoving On!");
            }

        }

        public virtual void BossArea()
        {
            Console.WriteLine($"BossArea: {AreaName} 1 Sieg, dann bool bossBesiegt auf true");
            Console.ReadLine();

            Kampf bossF = new BossKampf();
            bool bossBesiegt = false;
            int wins = 0;


            while (wins < 1)
            {
                bool win = bossF.StartKampf();

                if (win)
                {
                    wins++;
                }
                else
                {
                    Console.WriteLine("We Got Fucked!\nTactical Retreat!\nBack to the HQ");
                    return;
                }


            }

            if (wins == 1)
            {
                bossBesiegt = true;

                Console.WriteLine($"{AreaName} BOSS Conquered!\nMoving On!");
            }

        }



    }

    public class DesertOasis : Area
    {
        public DesertOasis() : base(
            areaName: "D - Desert Oasis",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nAn Oasis in the Desert.\nThe Gangs here specialize in EARTH, FIRE and TOXIN.\nThe Desert Oasis is ruled by the fearsome ELEPHANT Gang\n",
            easyAreaMon: new List<Mon>
            {
                new Moledigger(), new LampDjinn(), new Elephant(),
                new Kitsuninja(), new Cerberus(),
                new Viper(),
                
                // hier alle mons nur base, nur einzelne und 2er gangs, bossmon baseform!
            },
            midAreaMon: new List<Mon>
            {
                new Moledigger(), new LampDjinn(), new Sphinx(),
                new Kitsuninja(), new Cerberus(), new WaxGolem(),
                new Viper(), new Scorpio(),
                new CactusJack()
                // hier alle mons 2er gangs, manche mons base, manche random ausbildung
            },

            hardAreaMon: new List<Mon>
            {
                new LampDjinn(), new Sphinx(), new RockGolem(), new WarHog(),
                new Kitsuninja(), new Cerberus(), new WaxGolem(),
                new Viper(), new Scorpio(),
                new CactusJack()
                // hier alle mons 3er gangs, alle mons random ausbildung

            },

            bossAreaMon: new List<Mon>
            {
                new Elephant(), new Sphinx(), new Scorpio()
                // einmaliger kampf, statisches team, feste ausbildungen, manuell competetive set aufbauen!
            },
            homeBonusType: "Earth"
            )
        { } //   <== AN KONSTRUKTORKÖRPER GEDACHT, NICHT NOCH MAL 2 STUNDEN HÄNGEN

        public override void EnterArea() // OVERRIDE!!!
        {

            Console.WriteLine(AreaDescription);
            Console.WriteLine("Do You Want to Enter? Y/N");
            string eingabe = Console.ReadLine()?.Trim().ToUpper() ?? "";

            switch (eingabe)
            {
                case ("Y"):

                    Console.WriteLine($"Now Entering {AreaName}...\n");
                    EnterMusic();

                    Console.Clear();
                    EasyArea();
                    Console.ReadLine();

                    Console.Clear();
                    MidArea();
                    Console.ReadLine();

                    Console.Clear();
                    HardArea();
                    Console.ReadLine();

                    Console.Clear();
                    BossArea();
                    Console.ReadLine();

                    break;

                case ("N"):
                    return;


                default:

                    return;

            }


        }

        public override void EnterMusic() // OVERRIDE!!!
        {
            Music.MusicDesert();
        }


    }

    public class Swamplands : Area
    {
        public Swamplands() : base(
            areaName: "S - Swamplands",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nMurky and wet.\nThe Gangs here specialize in TOXIN, WATER and BIO.\nThe Swamplands are ruled by the treacherous ARACHNA Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Toxin"
            )
        { }

        public override void EnterArea() // OVERRIDE!!!
        {

            Console.WriteLine(AreaDescription);
            Console.WriteLine("Do You Want to Enter? Y/N");
            string eingabe = Console.ReadLine()?.Trim().ToUpper() ?? "";

            switch (eingabe)
            {
                case ("Y"):

                    Console.WriteLine($"Now Entering {AreaName}...\n");
                    EnterMusic();
                    EasyArea();

                    MidArea();

                    HardArea();

                    BossArea();

                    break;

                case ("N"):
                    return;


                default:

                    return;

            }


        }

        public override void EnterMusic() // OVERRIDE!!!
        {
            Music.MusicSwamp();
        }


    }

    public class JungleTribes : Area
    {
        public JungleTribes() : base(
            areaName: "J - Jungle Tribes",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nWhen you hear the Bongos, You're in the Jungle Tribeslands.\nThe Gangs here specialize in BIO, TOXIN and AIR.\nThe Jungle Tribes are ruled by the tricky ENT Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Bio"
            )
        { }
    }


    public class UnderwaterBase : Area
    {
        public UnderwaterBase() : base(
            areaName: "U - Underwater Base",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nAn Underwater Bunker from the Old Days.\nThe Gangs here specialize in WATER, ICE and TOXIN.\nThe Underwater Base is ruled by the blood-thirsty JAWS Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Water"
            )
        { }
    }


    public class FrozenTundra : Area
    {
        public FrozenTundra() : base(
            areaName: "F - Frozen Tundra",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nA harsh Frozen Wasteland.\nThe Gangs here specialize in ICE, WATER and FIRE.\nThe Frozen Tundra is ruled by the merciless ICEREX Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Ice"
            )
        { }
    }


    public class Volcano : Area
    {
        public Volcano() : base(
            areaName: "V - Volcano",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nCaldera of active Volcano.\nThe Gangs here specialize in FIRE, EARTH and TOXIN.\nThe Volcano is ruled by the hot-headed FIREREX Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Fire"
            )
        { }
    }


    public class Airship : Area
    {
        public Airship() : base(
            areaName: "A - Airship",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nAn enormous Airship.\nThe Gangs here specialize in AIR, LIGHTNING and ICE.\nThe Airship is ruled by the royal GRIFFIN Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Air"
            )
        { }
    }


    public class PowerPlant : Area
    {
        public PowerPlant() : base(
            areaName: "P - Power Plant",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nA Power Plant from the Old Days.\nThe Gangs here specialize in LIGHTNING, FIRE and EARTH.\nThe Power Plant is ruled by the crazy GOAT OF THUNDER Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Lightning"
            )
        { }
    }

    public class NightmareDimension : Area
    {
        public NightmareDimension() : base(
            areaName: "N - Nightmare Dimension",
            bossBesiegt: false,
            areaConquered: false,
            areaDescription: $"\nWTF IS THIS? A NIGHTMARE?\nThe Gangs here specialize in SHADOW, FIRE and TOXIN.\nThe Nightmare Dimension is ruled by the terrifying SHADOWREX Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Shadow"
            )
        { }
    }


    public static class AreaList
    {
        public static List<Area> areaList = new List<Area>
    {
        new DesertOasis(),
        new Swamplands(),
        new JungleTribes(),
        new UnderwaterBase(),
        new FrozenTundra(),
        new Volcano(),
        new Airship(),
        new PowerPlant(),
        new NightmareDimension()
    };
    }






}





