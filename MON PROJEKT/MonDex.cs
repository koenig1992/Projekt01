using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
    public class Zaptor : Mon
    {
        public Zaptor() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Zaptor",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Middleweight,
            monTypes: new List<MonType> { MonType.Lightning },
            levelExp: 1,
            klassen: new List<Klasse> { Klasse.Base },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 85 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 45 },
            { Stat.Speed, 90 }
            },

            attackenAktuell: new List<Attacke>
            {
                AttackenDex.a1,
                AttackenDex.a2
            },

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("RA RA RAAA");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }

    }

    public class Elephant : Mon
    {
        public Elephant() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Elephant",
            genos: Genos.Therioid,
            weightClass: WeightClass.SuperHeavyweight,
            monTypes: new List<MonType> { MonType.Earth },
            levelExp: 1,
            klassen: new List<Klasse> { Klasse.Base },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 100 },
            { Stat.Stamina, 55 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 70 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 20 },
            { Stat.PsyDef, 45 },
            { Stat.Speed, 45 }
            },

            attackenAktuell: new List<Attacke>
            {
                AttackenDex.a1,
                AttackenDex.a3
            },

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("GAAAROOOOOOWWW");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }


    }

    public class Salamander : Mon
    {
        public Salamander() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Salamander",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monTypes: new List<MonType> { MonType.Fire },
            levelExp: 1,
            klassen: new List<Klasse> { Klasse.Base },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 30 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 80 },
            { Stat.Speed, 40 }
            },

            attackenAktuell: new List<Attacke>
            {
                AttackenDex.a1,
                AttackenDex.a4
            },

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a4
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GARGL GARGL GARGL");
            Console.ResetColor();
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
        }


    }
}






