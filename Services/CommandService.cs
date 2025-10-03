using CerealDatabase.Models;
using Microsoft.EntityFrameworkCore;

    // Handles CRUD: enables the database to handle Create, Read, Update and Delete operations
    public class CommandService
    {
        private readonly AppDbContext _db;

        public CommandService(AppDbContext db)
        {
            _db = db;
        }

    // Returns true if cereal of given name exists in database
    public bool IsInDatabase(string name)
    {
        var existing = _db.Cereals.Find(name);
        if (existing == null)
        {
            return false;
        }
        return true;
    }

        // Create: posts cereal to database, if it doesn't already exist
    public void AddCereal(Cereal cereal)
    {
        if (IsInDatabase(cereal.Name))
        {
            throw new CerealFoundException(cereal.Name);
        }
        _db.Cereals.Add(cereal);
        _db.SaveChanges();
        Console.WriteLine(cereal.Name + " posted to database");
    }

        // Read: returns cereal coresponding to ID = name (primary key), if it exists in database
        public Cereal GetCereal(string name)
        {
            var inDatabase = _db.Cereals.Find(name);
            if (inDatabase == null)
            {
                throw new CerealNotFoundException(name);
            }
            return inDatabase;
        }

        // Read: returns a list of all cereals in database
        public List<Cereal> GetAllCereals()
        {
            return _db.Cereals.ToList();
        }      

        // Update: updates (put) values of cereal, if cereal exists in database
    public void UpdateCereal(Cereal cereal)
    {
        var inDatabase = _db.Cereals.Find(cereal.Name);
        if (inDatabase == null)
        {
            throw new CerealNotFoundException(cereal.Name);
        }
        _db.Entry(inDatabase).CurrentValues.SetValues(cereal);
        _db.SaveChanges();
        Console.WriteLine(cereal.Name + " updated");
    }

        // Delete: removes cereal from database, if cereal exists in database
        public void DeleteCereal(string name)
        {
            var inDatabase = _db.Cereals.Find(name);
            if (inDatabase == null)
            {
                throw new CerealNotFoundException(name);
            }
                _db.Cereals.Remove(inDatabase);
                _db.SaveChanges();
                Console.WriteLine(name + " deleted");
        }
        
    }
