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

        Console.WriteLine("Testing create cereal command");
        commander.AddCereal(new Cereal {Name = "Super Basic", Mfr = CerealDatabase.Models.Manufacturer.A, Type = CerealDatabase.Models.Type.H, Calories = 130, Protein = 3, Fat = 2, Sodium = 210, Fiber = 2, Carbo = 18, Sugars = 8, Potass = 100, Vitamins = 25, Shelf = 3, Weight = 1, Cups = 2, Rating = 37038562 });

        Console.WriteLine("Testing commmand for getting super basic cereal");
        Cereal basic = commander.GetCereal("Super Basic");
        Console.WriteLine(basic);

        Console.WriteLine("Testing update command");
        commander.UpdateCereal(new Cereal {Name = "Super Basic", Mfr = CerealDatabase.Models.Manufacturer.G, Type = CerealDatabase.Models.Type.H, Calories = 130, Protein = 3, Fat = 2, Sodium = 210, Fiber = 2, Carbo = 18, Sugars = 8, Potass = 100, Vitamins = 25, Shelf = 3, Weight = 1, Cups = 2, Rating = 37038562 });


        Console.WriteLine("Testing delete command");
        commander.DeleteCereal("Super Basic");

        Console.WriteLine("Testing queries");
        QueryService query = new QueryService(_db);

        Console.WriteLine("Testing query for getting all cereals with 70 calories");
        List<Cereal> cereals = query.GetCerealsByCalories(70);
        foreach (Cereal cereal in cereals) {
            Console.WriteLine(cereal);
        }
    }

}