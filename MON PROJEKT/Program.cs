using MON_PROJEKT;

class program
{

    static void Main()
    {
        StoryEvent.Intro();

        StoryEvent.ChooseMon();

        StoryEvent.Tutorial();



        while (true) // hauptgame
        {

            StoryEvent.ChooseArea(AreaList.areaList);

            
       

        }

       



        /*
        while (true)
        {
            Console.WriteLine("LASS MAL MUSIK TESTEN:\n" +
                "1 - Desert\n" +
                "2 - Forest/Junge\n" +
                "3 - Marsh/Swamp\n" +
                "4 - Underwater" +
                "5 - Polar\n" +
                "6 - Volcano\n" +
                "7 - Sky\n" +
                "8 - PowerPLant\n" +
                "9 - Nightlands\n");

            string eingabe = Console.ReadLine();
            switch (eingabe)
            {
                

                case ("1"):
                    Console.WriteLine("MusicDesert");
                    Music.MusicDesert();
                    Console.ReadLine();
                    break;

                case ("2"):
                    Console.WriteLine("Jingle Forest1");
                    Music.Forest1();
                    Console.ReadLine();
                    
                    Console.WriteLine("Jingle Forest2");
                    Music.Forest2();
                    Console.ReadLine();
                    
                    Console.WriteLine("Jingle Forest3");
                    Music.Forest3();
                    Console.ReadLine();

                    Console.WriteLine("Jingle Forest4");
                    Music.Forest4();
                    Console.ReadLine();
                    break;

                case ("3"):
                    Console.WriteLine("Swamp");
                    Music.MusicSwamp();
                    Console.ReadLine();
                    break;

                case ("4"):
                    Console.WriteLine("Polar");
                    Music.Jingle_Polar();
                    Console.ReadLine();
                    break;

                case ("5"):
                    Console.WriteLine("Volcano");
                    Music.Jingle_Volcano();
                    Console.ReadLine();
                    break;

                case ("6"):
                    Console.WriteLine("Sky");
                    Music.Jingle_Sky();
                    Console.ReadLine();
                    break;

                case ("7"):
                    Console.WriteLine("PowerPlant");
                    Music.Jingle_PowerPlant();
                    Console.ReadLine();
                    break;

                case ("8"):
                    Console.WriteLine("Nightlands");
                    Music.Jingle_Nightlands();
                    Console.ReadLine();
                    break;





                    Console.WriteLine("Nightlands");
                    Music.Jingle_Nightlands();
                    Console.ReadLine();

            }
            


        }
    */
        List<Mon> monDex = new List<Mon>
   {
       new Elephant(),
       new WarHog(),
       new Sphinx(),
       new LampDjinn(),
       new RockGolem(),
       new Moledigger(),

       new Ent(),
       new CactusJack(),
       new Pixie(),
       new WoodPuppet(),
       new Squirrior(),
       new MothMan(),

       new Arachna(),
       new Scorpio(),
       new Viper(),
       new GooGolem(),
       new Virat(),
       new Toxolotl(),

       new Cthulhuist(),
       new HammerHead(),
       new AssassiGator(),
       new KrustyKrabster(),
       new Aqualotl(),
       new Jaws(),

       new IceRex(),
       new SnowGolem(),
       new SnowlBear(),
       new PenguinEmperor(),
       new Lycan(),

       new FireRex(),
       new Pyromander(),
       new Cerberus(),
       new Pumpking(),
       new Kitsuninja(),
       new WaxGolem(),

       new Griffin(),
       new Valkyrie(),
       new BellGolem(),
       new BalloonFrog(),
       new Aeroptaeryx(),
       new Krow(),

       new GoatOfThunder(),
       new Zaptor(),
       new RoboGolem(),
       new Jellectric(),
       new GlowFly(),
       new Electrolotl(),

       new ShadowRex(),
       new Voodoll(),
       new Vampula(),
       new GoblinShark(),
       new Gremlin(),
       new Imp(),
   };





        while (true)
        {

            Console.WriteLine("START TEST");

            Console.ReadKey();

            Mon gremlin = new Gremlin();
            gremlin.MonInfo();
            Console.ReadLine();
            gremlin.WechselKlasse();
            Console.ReadLine();

            Mon jellectric = new Jellectric();
            jellectric.MonInfo();
            Console.ReadLine();
            jellectric.WechselKlasse();
            Console.ReadLine();

            Mon griffin = new Griffin();
            griffin.MonInfo();
            Console.ReadLine();
            griffin.WechselKlasse();
            Console.ReadLine();

            Mon iceRex = new IceRex();
            iceRex.MonInfo();
            Console.ReadLine();
            iceRex.WechselKlasse();
            Console.ReadLine();

            Mon jaws = new Jaws();
            jaws.MonInfo();
            Console.ReadLine();
            jaws.WechselKlasse();
            Console.ReadKey();

            Mon cthulhuist = new Cthulhuist();
            cthulhuist.MonInfo();
            Console.ReadKey();
            cthulhuist.WechselKlasse();
            Console.ReadKey();

            Mon toxolotl = new Toxolotl();
            toxolotl.MonInfo();
            Console.ReadLine();

            Mon elephant = new Elephant();
            elephant.MonInfo();
            Console.ReadKey();
            elephant.WechselKlasse();
            Console.ReadKey();

            Mon lampDjinn = new LampDjinn();
            lampDjinn.MonInfo();
            Console.ReadKey();
            lampDjinn.WechselKlasse();
            Console.ReadKey();


            Mon ent = new Ent();
            ent.MonInfo();
            Console.ReadKey();
            ent.WechselKlasse();
            Console.ReadKey();


            Mon gooGolem = new GooGolem();
            gooGolem.MonInfo();
            Console.ReadLine();
            gooGolem.WechselKlasse();
            Console.ReadLine();
            gooGolem.MonInfo();

            Mon zaptor = new Zaptor();
            zaptor.MonInfo();
            Console.ReadLine();
            zaptor.WechselKlasse();
            Console.ReadLine();
            zaptor.MonInfo();
            Console.ReadLine();



            Mon salamander = new Pyromander();
            salamander.MonInfo();
            Console.ReadLine();
            salamander.WechselKlasse();
            Console.ReadLine();

            Console.WriteLine("TEST ENDE");
            Console.ReadLine();
        }
    }
}









