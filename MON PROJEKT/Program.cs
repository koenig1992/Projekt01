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

        Mon elephant = new Elephant();
        elephant.MonInfo();

        Console.ReadKey();

        Mon salamander = new Salamander();
        salamander.MonInfo();

        Console.ReadKey();

        Console.WriteLine("TEST ENDE");
        Console.ReadKey();

    }
}









