using CsvHelper;
using System.Globalization;
using CerealDatabase.Models;
using CsvHelper.Configuration;


public class CerealCsvParser
{
    public List<Cereal> Parse(string filePath)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            HeaderValidated = null,
            MissingFieldFound = null
        };
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, config);
        return csv.GetRecords<Cereal>().ToList();
    }
}
