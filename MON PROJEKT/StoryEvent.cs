using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

            Console.WriteLine("VORGESCHICHTEEEE\nAPOKALYPSE\nATOMARE VERSEUCHUNG UND MUTATION\nKEINE MENSCHEN MEHR, NUR MONS\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void ChooseMon()
        {
            Console.WriteLine("Choose Your Starter Mon\n");
            Console.WriteLine("Your Options:\n");
            Console.ReadLine();
            List<Mon> StarterMon = new List<Mon>
            {
                // WarHog, Pixie, Cthulhuist, Toxolotl, SnowlBear, Cerberus, Valkyrie, Zaptor

                        new WarHog(),
                        new Pyromander(),
                        new AssassiGator (),
                        new Pixie(),

            };


            bool starterGewählt = false;

            while (!starterGewählt)
            {
                Console.WriteLine("The sturdy generalist Earth Mon WarHog\nThe pyromaniac but slow Fire Mon Pyromander\nThe strong but dumb Water Mon AssassiGator\nThe magical but frail Bio Mon Pixie\n");
                Console.WriteLine("\nEnter the name of your Mon");



                string starterInput = Console.ReadLine()?.Trim().ToUpper();


                switch (starterInput)
                {
                    case "WARHOG":
                        PlayerParty.PlayerPartyArray[0] = new WarHog();
                        starterGewählt = true;

                        break;
                    case "PYROMANDER":
                        PlayerParty.PlayerPartyArray[0] = new Pyromander();
                        starterGewählt = true;

                        break;
                    case "ASSASSIGATOR":
                        PlayerParty.PlayerPartyArray[0] = new AssassiGator();
                        starterGewählt = true;

                        break;
                    case "PIXIE":
                        PlayerParty.PlayerPartyArray[0] = new Pixie();
                        starterGewählt = true;

                        break;

                    default:
                        Console.WriteLine("Please Choose One of Those 4 to Join Your Gang");
                        break;
                }

            }

            Console.Clear();

            Console.WriteLine($"{PlayerParty.PlayerPartyArray[0].MonName} Joined Your Gang!");
            PlayerParty.PlayerPartyArray[0].MonInfo();

            Console.ReadLine();
            Console.Clear();


        }

        public static void Tutorial()
        {
            Console.WriteLine("hier sollte ein tutorial kommen. wird leider nix mehr. muss um 16:30 git pushen. anykey und weiter gehts");
            Console.ReadLine();
            Console.Clear();
        }

        public static void ChooseArea(List<Area> areaList)
        {
            Console.WriteLine("Which Area Do You Want to Conquer?\nEnter Valid Initial\n");
            Console.WriteLine("ACHTUNG MICHAEL, NUR BEI DER EINGABE D KOMMST DU IN EINE HALBWEGS FERTIGE VERSION, DIE ANDEREN SIND NUR LEERE GERÜSTE");

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

                case ("S"):
                    Area swamplands = new Swamplands();
                    swamplands.EnterArea();

                    break;

                default:
                    Console.WriteLine("Enter Valid Initial");
                    return;
                    
            }

            
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

    }
}