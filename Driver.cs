using System;

// Driver class for testing API for cereal database
class Driver
{

    private readonly AppDbContext _db; // Database being used for testing

    public Driver(AppDbContext db)
    {
        _db = db;
    }

    public void Run() // Runs tests from driverclass
    {
        Console.WriteLine("Running driver tests on API for cereal database");
        Seeder seeder = new Seeder(_db);
        seeder.Seed("Data/Cereal.csv");

        Console.WriteLine("Testing commands");
        CommandService commander = new CommandService(_db);
        Console.WriteLine("Testing commmand for getting cornflakes");
        Cereal cornFlakes = commander.GetCereal("Corn Flakes");
        Console.WriteLine(cornFlakes);

        Console.WriteLine("Testing queries");
        QueryService query = new QueryService(_db);
        Console.WriteLine("Testing query for getting all cereals with 70 calories");
        List<Cereal> cereals = query.GetCerealsByCalories(70);
        foreach (Cereal cereal in cereals) {
            Console.WriteLine(cereal);
        }
    }

}