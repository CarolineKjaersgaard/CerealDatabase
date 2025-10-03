using CerealDatabase.Models;
using Microsoft.EntityFrameworkCore;

// Handles filtering operatoins on database containing cereals
public class QueryService
{
    private readonly AppDbContext _db;

    public QueryService(AppDbContext db)
    {
        _db = db;
    }

    // Returns all cereals by given manufaturer
    public List<Cereal> GetCerealsByManufactures(Manufacturer manufacturer)
    {
        return _db.Cereals.Where(c => c.Mfr == manufacturer).ToList();
    }

    // Returns all cereals of given type
    public List<Cereal> GetCerealsByTypes(CerealDatabase.Models.Type type)
    {
        return _db.Cereals.Where(c => c.Type == type).ToList();
    }

    // Returns all cereals with given amount of calories
    public List<Cereal> GetCerealsByCalories(int calories)
    {
        return _db.Cereals.Where(c => c.Calories == calories).ToList();
    }

    // Returns all cereals with given amount of proteins
    public List<Cereal> GetCerealsByProtien(int protein)
    {
        return _db.Cereals.Where(c => c.Protein == protein).ToList();
    }

    // Returns all cereals with given amount of fat
    public List<Cereal> GetCerealsByFat(int fat)
    {
        return _db.Cereals.Where(c => c.Fat == fat).ToList();
    }

    // Returns all cereals with given amount of sodium
    public List<Cereal> GetCerealsBySodium(int sodium)
    {
        return _db.Cereals.Where(c => c.Sodium == sodium).ToList();
    }

    // Returns all cereals with given amount of fiber
    public List<Cereal> GetCerealsByFiber(float fiber)
    {
        return _db.Cereals.Where(c => c.Fiber == fiber).ToList();
    }

    // Returns all cereals with given amount of carbohydrates
    public List<Cereal> GetCerealsByCarbo(float carbo)
    {
        return _db.Cereals.Where(c => c.Carbo == carbo).ToList();
    }

    // Returns all cereals with given amount of sugar
    public List<Cereal> GetCerealsBySugars(int sugars)
    {
        return _db.Cereals.Where(c => c.Sugars == sugars).ToList();
    }

    // Returns all cereals with given amount of potassium
    public List<Cereal> GetCerealsByPotass(int potass)
    {
        return _db.Cereals.Where(c => c.Potass == potass).ToList();
    }

    // Returns all cereals with given amount of vitamins
    public List<Cereal> GetCerealsByVitamins(int vitamins)
    {
        return _db.Cereals.Where(c => c.Vitamins == vitamins).ToList();
    }

    // Returns all cereals on given shelf
    public List<Cereal> GetCerealsByShelf(int shelf)
    {
        return _db.Cereals.Where(c => c.Shelf == shelf).ToList();
    }

    // Returns all cereals with given weight
    public List<Cereal> GetCerealsByWeight(float weight)
    {
        return _db.Cereals.Where(c => c.Weight == weight).ToList();
    }

    // Returns all cereals with given amount of cups
    public List<Cereal> GetCerealsByCups(float cups)
    {
        return _db.Cereals.Where(c => c.Cups == cups).ToList();
    }
    
    // Returns all cereals with given rating
        public List<Cereal> GetCerealsByRating(int rating)
    {
        return _db.Cereals.Where(c => c.Rating == rating).ToList();
    }
}