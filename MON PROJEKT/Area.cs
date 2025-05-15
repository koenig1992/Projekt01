using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MON_PROJEKT
{

    public abstract class Area
    {
        public string AreaName { get; set; } // UMBENENNEN WENN AREA ABGESCHLOSSEN; DESHALB AUCH SET
        public bool BossBesiegt { get; set; }

        public string AreaDescription { get; }

        public List<Mon> EasyAreaMon { get; set; }

        public List<Mon> MidAreaMon { get; set; }

        public List<Mon> HardAreaMon { get; set; }

        public List<Mon> BossAreaMon { get; set; }

        public string HomeBonusType { get; }


        protected Area(string areaName, bool bossBesiegt, string areaDescription, List<Mon> easyAreaMon, List<Mon> midAreaMon, List<Mon> hardAreaMon, List<Mon> bossAreaMon, string homeBonusType)
        {
            AreaName = areaName;
            BossBesiegt = false;
            AreaDescription = areaDescription;
            EasyAreaMon = new List<Mon>();
            MidAreaMon = new List<Mon>();
            HardAreaMon = new List<Mon>();
            BossAreaMon = new List<Mon>();
            HomeBonusType = homeBonusType;

        }

        public virtual void EnterMusic() // <== VIRTUAL METHODE, DAMIT ICH SPÄTER OVERRIDE VERWENDEN KANN
        {
        }

    }

    public class DesertOasis : Area
    {
        public DesertOasis() : base(
            areaName: "D - Desert Oasis",
            bossBesiegt: false,
            areaDescription: $"An Oasis in the Desert.\nThe Gangs here specialize in Earth, FIRE and TOXIN.\nThe Desert Oasis is ruled by the fearsome ELEPHANT Gang\n",
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

        public override void EnterMusic() // OVERRIDE!!!
        {
            Console.WriteLine($"{Music.MusicDesert}");
        }


    }

    public class Swamplands : Area
    {
        public Swamplands() : base(
            areaName: "S - Swamplands",
            bossBesiegt: false,
            areaDescription: $"Murky and wet.\nThe Gangs here specialize in TOXIN, WATER and BIO.\nThe Swamplands are ruled by the treacherous ARACHNA Gang\n",
            easyAreaMon: new List<Mon>(),
            midAreaMon: new List<Mon>(),
            hardAreaMon: new List<Mon>(),
            bossAreaMon: new List<Mon>(),
            homeBonusType: "Toxin"
            )
        { }

        public override void EnterMusic()
        {
            Music.MusicSwamp();
        }



    }

    public class JungleTribes : Area
    {
        public JungleTribes() : base(
            areaName: "J - Jungle Tribes",
            bossBesiegt: false,
            areaDescription: $"When you hear the Bongos, You're in the Jungle Tribeslands.\nThe Gangs here specialize in BIO, TOXIN and AIR.\nThe Jungle Tribes are ruled by the tricky ENT Gang\n",
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
            areaName: "Underwater Base",
            bossBesiegt: false,
            areaDescription: $"An Underwater Bunker from the Old Days.\nThe Gangs here specialize in WATER, ICE and TOXIN.\nThe Underwater Base is ruled by the blood-thirsty JAWS Gang\n",
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
            areaDescription: $"A harsh Frozen Wasteland.\nThe Gangs here specialize in ICE, WATER and FIRE.\nThe Frozen Tundra is ruled by the merciless ICEREX Gang\n",
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
            areaDescription: $"Caldera of active Volcano.\nThe Gangs here specialize in FIRE, EARTH and TOXIN.\nThe Volcano is ruled by the hot-headed FIREREX Gang\n",
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
            areaDescription: $"An enormous Airship.\nThe Gangs here specialize in AIR, LIGHTNING and ICE.\nThe Airship is ruled by the royal GRIFFIN Gang\n",
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
            areaDescription: $"A Power Plant from the Old Days.\nThe Gangs here specialize in LIGHTNING, FIRE and EARTH.\nThe Power Plant is ruled by the crazy GOAT OF THUNDER Gang\n",
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
            areaDescription: $"WTF IS THIS? A NIGHTMARE?\nThe Gangs here specialize in SHADOW, FIRE and TOXIN.\nThe Nightmare Dimension is ruled by the terrifying SHADOWREX Gang\n",
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

    /* public static class AreaList
    {


        List<Area> areaList = new List<Area>

        {
            new Area("D - Desert Oasis"),
            new Area("S - Swamplands"),
            new Area("J - Jungle Tribes"),
            new Area("U - Underwater Base"),
            new Area("F - Frozen Tundra"),
            new Area("V - Volcano"),
            new Area("A - Airship"),
            new Area("P - Power Plant"),
            new Area("N - Nightmare Dimension"),

        }; 
    }*/

}





