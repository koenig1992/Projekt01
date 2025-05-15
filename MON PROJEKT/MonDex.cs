using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
   

    public class Elephant : Mon
    {
        public Elephant() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Elephant",
            genos: Genos.Therioid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 100 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 90 },
            { Stat.PhyDef, 80 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 20 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("GAROOOOOUUU");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);


        }
    }

    public class WarHog : Mon
    {
        public WarHog() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "War Hog",
            genos: Genos.Therioid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 70 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 70 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 20 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 60 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("OINK OINK");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }




    public class Sphinx : Mon
    {
        public Sphinx() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Sphinx",
            genos: Genos.Therioid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 50 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 70 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("MEEEOW");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }


    public class LampDjinn : Mon
    {
        public LampDjinn() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Lamp Djinn",
            genos: Genos.Organoid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 40 },
            { Stat.PhyDef, 70 },
            { Stat.Psymina, 70 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("JALALA");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }

    public class RockGolem : Mon
    {
        public RockGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Rock Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class Moledigger : Mon
    {
        public Moledigger() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Mole Digger",
            genos: Genos.Therioid,
            weightClass: WeightClass.Featherweight,
            monType: MonAttackType.Earth,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 30 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 40 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("*SNIFFLE SNIFFLE*");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }





    public class Ent : Mon
    {
        public Ent() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Ent",
            genos: Genos.Phytoid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.ROGUE, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 60 },
            { Stat.PhyDef, 80 },
            { Stat.Psymina, 90 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 20 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HMMMMMM");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }


    public class CactusJack : Mon
    {
        public CactusJack() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Cactus Jack",
            genos: Genos.Phytoid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 80 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 50 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("KA KA KA KA KA");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }



    public class Pixie : Mon
    {
        public Pixie() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Pixie",
            genos: Genos.Phytoid,
            weightClass: WeightClass.Featherweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 30 },
            { Stat.Stamina, 50 },
            { Stat.PhyAtk, 20 },
            { Stat.PhyDef, 30 },
            { Stat.Psymina, 100 },
            { Stat.PsyAtk, 90 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CHIII CHIII");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }



    public class WoodPuppet : Mon
    {
        public WoodPuppet() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Wood Puppet",
            genos: Genos.Organoid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 80 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 20 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*HAMMERS ON THE GROUND*");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }



    public class Squirrior : Mon
    {
        public Squirrior() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Squirrior",
            genos: Genos.Phytoid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SQUEAK SQUEAK");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }




    public class MothMan : Mon
    {
        public MothMan() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Moth Man",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Bio,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 30 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 70 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*OMINOUS SILENCE");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }




    public class Arachna : Mon
    {
        public Arachna() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Arachna",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.ROGUE, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 60 },
            { Stat.Stamina, 70 },
            { Stat.PhyAtk, 60 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 50 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ZEEEHAHAHA");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }






    public class Scorpio : Mon
    {
        public Scorpio() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Scorpio",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 40 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("SHHHHHH");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }





    public class Viper : Mon
    {
        public Viper() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Viper",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("SSSSSSSSSSS");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(300, 1000);
        }
    }





    public class GooGolem : Mon
    {
        public GooGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Goo Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class Virat : Mon
    {
        public Virat() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "´Virat",
            genos: Genos.Therioid,
            weightClass: WeightClass.Featherweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.ROGUE, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 70 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 40 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("SQUEAK SQUEAK");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class Toxolotl : Mon
    {
        public Toxolotl() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Toxolotl",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class Cthulhuist : Mon
    {
        public Cthulhuist() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Cthulhuist",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Water,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 30 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 90 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CTHULHU RLYEH WGAH'NAGL FTHAGN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class HammerHead : Mon
    {
        public HammerHead() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "HammerHead",
            genos: Genos.Ichthyoid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Water,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.ROGUE },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 60 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ____/|_____          ");
            Console.WriteLine("(*)(vvvvv)(+) FUCK YOU");
            Console.WriteLine("  |-^^^^^-|            ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class Aqualotl : Mon
    {
        public Aqualotl() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Aqualotl",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class KrustyKrabster : Mon
    {
        public KrustyKrabster() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Krusty Krabster",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Water,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 50 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 80 },
            { Stat.Psymina, 40 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 40 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CRAAAAAB PEOPLE CRAAAAB PEOPLE - TALK LIKE PEOPLE, TASTE LIKE CRAB");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class AssassiGator : Mon
    {
        public AssassiGator() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "AssassiGator",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Water,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 70 },
            { Stat.PhyAtk, 90 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 20 },
            { Stat.PsyAtk, 30 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 50 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("...");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class Jaws : Mon
    {
        public Jaws() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Jaws",
            genos: Genos.Ichthyoid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Water,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 90 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 20 },
            { Stat.PsyAtk, 30 },
            { Stat.PsyDef, 30 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_|  \\_____");
            Console.WriteLine("  ((( O---.)");
            Console.WriteLine("  VVVVVVVV  ");
            Console.WriteLine(" |          ");
            Console.WriteLine(" -^^^^^^^^. ");
            Console.WriteLine("___________)");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }





    public class IceRex : Mon
    {
        public IceRex() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "IceRex",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 100 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 30 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GAROOOOOUUUWWW");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class Lycan : Mon
    {
        public Lycan() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Lycan",
            genos: Genos.Therioid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 90 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 20 },
            { Stat.PsyAtk, 20 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("RUFF RUFF");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class PenguinEmperor : Mon
    {
        public PenguinEmperor() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "PenguinEmperor",
            genos: Genos.Ornithoid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 30 },
            { Stat.PhyAtk, 20 },
            { Stat.PhyDef, 70 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 40 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("QUEAK");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class SnowGolem : Mon
    {
        public SnowGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Snow Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class SnowlBear : Mon
    {
        public SnowlBear() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "SnowlBear",
            genos: Genos.Ornithoid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 50 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 50 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("HOOT HOOT");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }






    public class FireRex : Mon
    {
        public FireRex() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "FireRex",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 100 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 30 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAROOOOOUUUWWW");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class Pyromander : Mon
    {
        public Pyromander() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Pyromander",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Fire,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 40 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 80 },
            { Stat.Speed, 40 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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





    public class Cerberus : Mon
    {
        public Cerberus() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Cerberus",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Fire,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 70 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 20 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("RUFF RUFF RUFF (ONE RUFF PER HEAD)");
            Console.ResetColor();
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
        }
    }






    public class Pumpking : Mon
    {
        public Pumpking() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Pumpking",
            genos: Genos.Phytoid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Fire,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 50 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("BOOOOOOOOO");
            Console.ResetColor();
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
        }
    }





    public class Kitsuninja : Mon
    {
        public Kitsuninja() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Kitsuninja",
            genos: Genos.Therioid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Fire,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 50 },
            { Stat.PhyAtk, 40 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

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
            Console.WriteLine("WHAT DOES THE FOX SAY?");
            Console.ResetColor();
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
            Console.Beep(200, 200);
            Console.Beep(300, 200);
        }
    }




    public class WaxGolem : Mon
    {
        public WaxGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Wax Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Fire,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }






    public class Griffin : Mon
    {

        public Griffin() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Griffin",
            genos: Genos.Ornithoid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.ROGUE },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 90 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 30 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("RA RA RAAA");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }





    public class BellGolem : Mon
    {
        public BellGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Bell Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class Valkyrie : Mon
    {

        public Valkyrie() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Valkyrie",
            genos: Genos.Ornithoid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 70 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 40 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("RA RA RAAA");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }




    public class BalloonFrog : Mon
    {

        public BalloonFrog() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "BalloonFrog",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 20 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 70 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 80 },
            { Stat.Speed, 50 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("RIBBIT RIBBIT");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }



    public class Krow : Mon
    {

        public Krow() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Krow",
            genos: Genos.Ornithoid,
            weightClass: WeightClass.Featherweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.ROGUE, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 40 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 40 },
            { Stat.PhyDef, 40 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("KRRRRAW KRRRRAW");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }



    public class Aeroptaeryx : Mon
    {

        public Aeroptaeryx() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Aeroptaeryx",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Air,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 80 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 30 },
            { Stat.Psymina, 30 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 80 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("RA RA RAAA");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }




    public class GoatOfThunder : Mon
    {

        public GoatOfThunder() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Goat of Thunder",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Lightning,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.ROGUE },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 70 },
            { Stat.Psymina, 60 },
            { Stat.PsyAtk, 60 },
            { Stat.PsyDef, 40 },
            { Stat.Speed, 60 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("MÄÄÄÄÄÄÄÄH");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }


    public class Zaptor : Mon
    {

        public Zaptor() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Zaptor",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Lightning,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
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

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("RA RA RAAA");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }


    public class RoboGolem : Mon
    {
        public RoboGolem() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Robo Golem",
            genos: Genos.Organoid,
            weightClass: WeightClass.SuperHeavyweight,
            monType: MonAttackType.Lightning,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.SPELLCASTER, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 80 },
            { Stat.PhyDef, 90 },
            { Stat.Psymina, 50 },
            { Stat.PsyAtk, 50 },
            { Stat.PsyDef, 70 },
            { Stat.Speed, 10 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ÜN ÜN ÜN");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }




    public class GlowFly : Mon
    {

        public GlowFly() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "GlowFly",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Featherweight,
            monType: MonAttackType.Lightning,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 50 },
            { Stat.Stamina, 30 },
            { Stat.PhyAtk, 20 },
            { Stat.PhyDef, 50 },
            { Stat.Psymina, 70 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 90 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("BZZZZ BZZZZZ");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }



    public class Jellectric : Mon
    {

        public Jellectric() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Jellectric",
            genos: Genos.Aspondyloid,
            weightClass: WeightClass.Lightweight,
            monType: MonAttackType.Lightning,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 90 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 10 },
            { Stat.PhyDef, 30 },
            { Stat.Psymina, 100 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 90 },
            { Stat.Speed, 60 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a2,
                AttackenDex.a3,
                AttackenDex.a4,
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---");
            Console.ResetColor();
            Console.Beep(2000, 50);
            Console.Beep(2000, 50);
            Console.Beep(2000, 300);
        }
    }


    public class Electrolotl : Mon
    {
        public Electrolotl() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Electrolotl",
            genos: Genos.Amphibioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class ShadowRex : Mon
    {
        public ShadowRex() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "ShadowRex",
            genos: Genos.Sauroid,
            weightClass: WeightClass.Heavyweight,
            monType: MonAttackType.Ice,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.FIGHTER, MonKlasse.ROGUE, MonKlasse.MECHANIC },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 70 },
            { Stat.Stamina, 60 },
            { Stat.PhyAtk, 100 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 30 },
            { Stat.PsyAtk, 70 },
            { Stat.PsyDef, 50 },
            { Stat.Speed, 70 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("GAROOOOOUUUWWW");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }



    public class Voodoll : Mon
    {
        public Voodoll() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Voodoll",
            genos: Genos.Organoid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class Vampula : Mon
    {
        public Vampula() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Vampula",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class GoblinShark : Mon
    {
        public GoblinShark() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "GoblinShark",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class Gremlin : Mon
    {
        public Gremlin() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Gremlin",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }


    public class Imp : Mon
    {
        public Imp() : base(  // PARAMETER gesetzt, muss mit : base () übergeben werden
            monName: "Imp",
            genos: Genos.Therioid,
            weightClass: WeightClass.Middleweight,
            monType: MonAttackType.Toxin,
            levelExp: 1,
            klasseAktuell: MonKlasse.BASE,
            klassenOptionen: new List<MonKlasse> { MonKlasse.SPELLCASTER, MonKlasse.MECHANIC, MonKlasse.HEALER },
            stats: new Dictionary<Stat, int>
            {
            { Stat.HP, 80 },
            { Stat.Stamina, 40 },
            { Stat.PhyAtk, 30 },
            { Stat.PhyDef, 60 },
            { Stat.Psymina, 80 },
            { Stat.PsyAtk, 80 },
            { Stat.PsyDef, 60 },
            { Stat.Speed, 30 }
            },

           attackSlot1: AttackenDex.a1,
           attackSlot2: AttackenDex.a2,
           attackSlot3: AttackenDex.a3,
           attackSlot4: AttackenDex.a4,

            attackenLearnset: new List<Attacke>
            {

                AttackenDex.a1,
                AttackenDex.a3
            }

           )
        { } // <== 2 FUCKING STUNDEN!!!!!!! WTF. DAS IST DER KONSTRUKTOR KÖRPER. DER KANN LEER SEIN, MUSS ABER VORHANDEN SEIN!


        public override void SpriteCry()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" -|-|-(*_____*)-|-|- ");
            Console.ResetColor();
            Console.Beep(200, 300);
            Console.Beep(200, 300);
            Console.Beep(200, 300);
        }
    }

}








