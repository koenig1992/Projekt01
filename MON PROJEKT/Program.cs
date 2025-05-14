using MON_PROJEKT;

class program
{

    static void Main()
    {
        Console.WriteLine("START TEST");

        Console.ReadKey();

        Mon zaptor = new Zaptor();
        zaptor.MonInfo();
        Console.ReadKey();
        zaptor.WechselKlasse();
        Console.ReadKey();
        zaptor.MonInfo();

        Console.ReadKey();

        Mon elephant = new Elephant();
        elephant.MonInfo();
        Console.ReadKey();
        elephant.WechselKlasse();
        Console.ReadKey();

        Mon salamander = new Salamander();
        salamander.MonInfo();
        Console.ReadKey();
        salamander.WechselKlasse();
        Console.ReadKey();

        Console.WriteLine("TEST ENDE");
        Console.ReadKey();

    }
}









