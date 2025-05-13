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
            { Stat.HP, 60 },
            { Stat.Stamina, 55 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 30 },
            { Stat.PsyDef, 45 },
            { Stat.Speed, 75 }
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
            Console.WriteLine("⚡⚡⚡");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);


        }

    }


}

