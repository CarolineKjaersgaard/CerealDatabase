using CsvHelper;
using System.Globalization;
using CerealDatabase.Models;
using CsvHelper.Configuration;

// Takes csv file containg data of cereals and parses it using csvHelper
// Returns list of cereals from csv file
public class CsvParser
{
    public List<Cereal> Parse(string filePath)
    {
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<Cereal>().ToList();
    }
}
