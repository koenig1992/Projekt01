using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{


    public class Attacke // public class Attacke - WAS  MÜSSEN ATTACKEN BEINHALTEN
    {
        public int AttackDexNo { get; } // nicht veränderbar
        public string AttackName { get; } // nicht veränderbar
        public AttackType AttackType { get; } // enumeration AttackType, nicht veränderbar

        public AttackCategory AttackCategory { get; set; } // enumeration AttackCategory

        public int AttackCost { get; set; } // int AttackCost: -x stamina/ -y psymina

        public int Power { get; set; } // int Power

        public string AttackDescription { get; set; } // Description, evtl später für Effekte, zB poisoning

        public Attacke(int attackDexNo, string attackName, AttackType attackType, AttackCategory attackCategory, int attackCost, int power, string attackDescription)
        {
            AttackDexNo = attackDexNo;
            AttackName = attackName;
            AttackType = attackType;
            AttackCategory = attackCategory;
            AttackCost = attackCost;
            Power = power;
            AttackDescription = attackDescription;
        }

    }

    public static class AttackenDex // MÜSSEN STATIC SEIN!!!!!!!!
    {
        public static Attacke a1 = new Attacke
                   (attackDexNo: 1,
                 attackName: "Fire Fist",
                 attackType: AttackType.Fire,
                 attackCategory: AttackCategory.Physical,
                 attackCost: 20,
                 power: 70,
                 attackDescription: "jaja voll geile attacke, brudi"
      );

        public static Attacke a2 = new Attacke(
            attackDexNo: 2,
            attackName: "Kugelblitz",
            attackType: AttackType.Lightning,
            attackCategory: AttackCategory.Physical,
            attackCost: 40,
            power: 100,
            attackDescription: "BLITZZZZZZZZSCHLAG"


            );
    }
}


