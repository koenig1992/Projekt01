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
        public MonAttackType AttackType { get; } // enumeration AttackType, nicht veränderbar

        public AttackCategory AttackCategory { get; set; } // enumeration AttackCategory

        public int AttackCostStamina { get; set; } // int AttackCost: -x stamina/ -y psymina

        public int AttackCostPsymina { get; set; } // int AttackCost: -x stamina/ -y psymina


        public int Power { get; set; } // int Power

        public string AttackDescription { get; set; } // Description, evtl später für Effekte, zB poisoning

        public Attacke(int attackDexNo, string attackName, MonAttackType attackType, AttackCategory attackCategory, int attackCostSta, int attackCostPsy, int power, string attackDescription)
        {
            AttackDexNo = attackDexNo;
            AttackName = attackName;
            AttackType = attackType;
            AttackCategory = attackCategory;
            AttackCostStamina = attackCostSta;
            AttackCostPsymina = attackCostPsy;
            Power = power;
            AttackDescription = attackDescription;
        }

    }

    public static class AttackenDex // MÜSSEN STATIC SEIN!!!!!!!!
    {
        public static Attacke a1 = new Attacke(
            attackDexNo: 1,
            attackName: "Fire Fist",
            attackType: MonAttackType.Fire,
            attackCategory: AttackCategory.Physical,
            attackCostSta: 25,
            attackCostPsy: 10,
            power: 70,
            attackDescription: "jaja voll geile attacke, brudi"
            );

        public static Attacke a2 = new Attacke(
            attackDexNo: 2,
            attackName: "Kugelblitz",
            attackType: MonAttackType.Lightning,
            attackCategory: AttackCategory.Physical,
            attackCostSta: 10,
            attackCostPsy: 40,
            power: 100,
            attackDescription: "BLITZZZZZZZZSCHLAG"
        );

        public static Attacke a3 = new Attacke(
            attackDexNo: 3,
            attackName: "Earthquake",
            attackType: MonAttackType.Earth,
            attackCategory: AttackCategory.Physical,
            attackCostSta: 50,
            attackCostPsy: 0,
            power: 120,
            attackDescription: "EARTHQUAAAAAKE"
        );

        public static Attacke a4 = new Attacke(
            attackDexNo: 4,
            attackName: "MagmaBall",
            attackType: MonAttackType.Fire,
            attackCategory: AttackCategory.Psychic,
            attackCostSta: 0,
            attackCostPsy: 50,
            power: 110,
            attackDescription: "a Magma Ball erupts"
        );
    }
}


