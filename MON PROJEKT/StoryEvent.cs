using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
    internal class StoryEvent
    {
        public static void Intro()
        {

            Console.WriteLine("- press to start game -");
            Console.ReadLine();
            Console.Clear();

            Console.Beep(3100, 300);
            Console.Beep(2400, 300);
            Console.Beep(1800, 300);
            Console.Beep(1300, 300);
            Console.Beep(300, 3000);

            Console.WriteLine("        _._.-^^-.-^^-.-^^-._._      ");
            Console.WriteLine("    _-(-^ ^               ^ ^-)-_   ");
            Console.WriteLine("    (<                         >)   ");
            Console.WriteLine("   ((                           ))  ");
            Console.WriteLine("    (((._       _ _ _       _./))   ");
            Console.WriteLine("        ''''--. ; , ; .--''''       ");
            Console.WriteLine("               | | | |              ");
            Console.WriteLine("           ..-=| | | |=-..          ");
            Console.WriteLine("           ''-=#$%&%$#=-''          ");
            Console.WriteLine("               | | | |              ");
            Console.WriteLine(" _____.,,-,^,^#%&$@%#&#^,^,-,,._____\n\n\n");
            Console.ReadLine();

            Console.WriteLine("VORGESCHICHTEEEE KEINE MENSCHEEEEEN MUTATIOOOON\n");
        }

        public static void ChooseMon()
        {
            Console.WriteLine("Choose Your Starter Mon\n");
            Console.WriteLine("Your Options:\n");
            List<Mon> StarterMon = new List<Mon>
            {
// WarHog, Pixie, Cthulhuist, Toxolotl, SnowlBear, Cerberus, Valkyrie, Zaptor
            };

            string starter = Console.ReadLine();

            // starter -> Mon
            // gültige eingabe?
            // add Mon to PlayerParty



        }



        public static void ChooseArea(List<Area> areaList)
        {
            Console.WriteLine("Which Area Do You Want to Conquer?\nEnter Valid Initial\n");

            foreach (var area in areaList)
            {
                string areaStatus = area.BossBesiegt ? "(!CONQUERED!)" : ""; // für BossBesiegt true, gib aus (!CONQUERED!), ansonsten gib aus ""
                Console.WriteLine($"{area.AreaName} {areaStatus}");
            }

            string eingabe = Console.ReadLine()?.Trim().ToUpper() ?? "";

            switch (eingabe)
            {
                case ("D"):
                    Area desertOasis = new DesertOasis(); // <== MUSS ZUERST OBJEKT ERSTELLEN
                    desertOasis.EnterArea();                // UND DANN MIT DEM OBJEKT WEITERARBEITEN
                    break;                      

                case ("J"):
                    Area jungleTribes = new JungleTribes();
                        jungleTribes.EnterArea();
                    break;

                default:
                    Console.WriteLine("Enter Valid Initial");
                    return;

            }
        }



        public virtual void EnterArea()
        {
            Console.WriteLine($"Now entering {AreaName}..."); // OOOOOOOOOOOOOOOOOOOFFFFF, ZUGRIFF SCHWIERIG
            EnterMusic();



        }


        public static void WonFight()
        {

        }

        public static void WonAreaLevel()
        {
        
        }


        public static void LostFight()
        {

        }


        public static void WonBoss()
        {



        }

        public static void LostBoss()
        {



        }


        public static void WonGame()
        {
            Console.WriteLine("You Have Conquered the World!");
            Console.WriteLine("Your Gang Rules The World Now!");
            Console.WriteLine("Now Don't Be an Asshole - or Another Gang Will Come to Topple You Soon!\n");

        }

        public static void LostGame()
        {


        }



    }
}