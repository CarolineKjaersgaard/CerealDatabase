using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using CerealDatabase.Models;

public class CerealSeeder
{
    private readonly AppDbContext _db;
    private readonly CerealCsvParser _parser;

    public CerealSeeder(AppDbContext db)
    {
        _db = db;
        _parser = new CerealCsvParser();
    }

    public void Seed(string filePath)
    {


        var cereals = _parser.Parse(filePath);
        _db.Cereals.AddRange(cereals);
        _db.SaveChanges();
    }
}
