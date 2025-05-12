using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

    class Mon
    {
        public class Mon()
        {
            public string Name { get; set; }

            public string Genos { get;} // nicht veränderbar, nicht rechnerisch relevant

            public string MonType { get; set; }

            public string LevelExp { get; set; }

            public string Klasse { get; set; }

            public int Stats { get; set; }

            public string WeightClass { get; set; }

        }

        public virtual void Name()
        { }

        public virtual void Genos() // string genügt, nicht veränderbar, nicht rechnerisch relevant, nur "schön"
        {
            "Therioid", "Sauroid", "Amphibioid", "Ornithoid", "Ichthyoid", "Aspondyloid", "Phytoid", "Organoid";
 }

        public virtual void MonType() // vorerst string, ziel: List? Dictionary?
        {
            "Earth", "Bio", "Toxin", "Water", "Ice", "Fire", "Air", "Lightning", "Shadow";
 }

        public virtual void SpriteCry() // string für sprite, beep für cry
        { }

        public virtual void LevelExp()
        { }

        public virtual void Klasse() // vorerst string, ziel: List? Dictionary?
        {
            "Base", "Fighter", "Spellcaster", "Rogue", "Mechanic" "Healer";
}

        public virtual void Stats()
        { }

        public virtual void Attacks() // List? Dictionary? Attacks = zurzeit erlernte Attacken. Moveset = Lernbare Attacken
        { }


        public virtual void WeightClass()
        {
            "Featherweight", "Lightweight", "Middleweight", "Heavyweight", "SuperHeavyweight";
 }






        public enum MonClass
        {
            Base, Fighter, Spellcaster, Rogue, Mechanic, Healer
        }

        public enum WeightClass
        {
            Featherweight, Lightweight, Middleweight, Heavyweight, SuperHeavyweight
        }

        // === MON ATTACK ===
        public class Attack
        {
            public string Name { get; set; }
            public AttackType Type { get; set; }
            public int Power { get; set; }
            public string Description { get; set; }

            public Attack(string name, AttackType attackType, int power, string description)
            {
                Name = name;
                AttackType = attackType;
                Power = power;
                Description = description;
            }
        }


        public void MonInfo()
        {
            Mon.SpriteCry;

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Genos: {Genos}");
            Console.WriteLine($"Typ: {MonType}");
            Console.WriteLine($"Klasse: {Klasse}");
            Console.WriteLine($"Gewicht: {WeightClass}");
            Console.WriteLine($"Level: {LevelExp}");
            Console.WriteLine("Stats:");
            foreach (var stat in Stats)
            {
                Console.WriteLine($"  {stat.Key}: {stat.Value}");
            }

            Console.WriteLine("Attacken:");
            foreach (var move in Moveset)
            {
                Console.WriteLine($"  {move.Name} ({move.Type}) - {move.Power} Power");
            }

            Console.WriteLine();
        }



        // QUELLEN: Unterrichtsmaterial/Übung zu Dictionary, Methoden, Klassen, Vererbung
    }



}
