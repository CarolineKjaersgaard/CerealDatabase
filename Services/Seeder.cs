using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using CerealDatabase.Models;

// Seeds the database with cereals provided by a csv file given a filepath to a csv file containing cereals
public class Seeder
{
    private readonly AppDbContext _db;
    private readonly CsvParser _parser;

    public Seeder(AppDbContext db)
    {
        _db = db;
        _parser = new CsvParser();
    }

    // Uses the parser to add cereals to the database
    public void Seed(string filePath)
    {
        var cereals = _parser.Parse(filePath);

        foreach (var cereal in cereals)
        {
            var existing = _db.Cereals.Find(cereal.Name);
            if (existing == null)
            {
                _db.Cereals.Add(cereal);
            }
            else
            {
                _db.Entry(existing).CurrentValues.SetValues(cereal);
            }
        }

        _db.SaveChanges();
    }
}
