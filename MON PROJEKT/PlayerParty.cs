using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
    internal class PlayerParty
    {
        public static Mon[] PlayerPartyArray = new Mon[3];


        public static void PlayerPartyAnzeigen()
        {
            Console.WriteLine("Your Gang:\n");
            for (int i = 0; i < PlayerPartyArray.Length; i++)
            {
                var mon = PlayerParty.PlayerPartyArray[i];
                Console.WriteLine($"{i + 1}.: ");
                if (mon != null)
                {

                    mon.MonInfo();
                }
                else
                {
                    Console.WriteLine([]);
                }
            }


        }
    }
}

