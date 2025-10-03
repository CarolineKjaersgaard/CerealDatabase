using System;
using CerealDatabase.Models;

// Represents a dataitem in database
public class Cereal
{
    public required string Name { get; set; } // ID of dataitem, name of cereal
    public required Manufacturer Mfr { get; set; } // Manufaturer
    public required CerealDatabase.Models.Type Type { get; set; } // Type (hot/cold)
    public int Calories { get; set; } // Calories pr. portion
    public int Protein { get; set; } // Grams of protein pr. portion
    public int Fat { get; set; } // Grams of fat pr. portion
    public int Sodium { get; set; } // Milligrams of sodium pr. portion
    public float Fiber { get; set; } // Grams of fiber pr. portion
    public float Carbo { get; set; } // Grams of carbohydrates pr. portion
    public int Sugars { get; set; } // Grams of sugar pr. portion
    public int Potass { get; set; } // Milligrams of potassium pr. portion
    public int Vitamins { get; set; } // Vitamin percentage according to FDA-recomendation
    public int Shelf { get; set; } // Placement on shelf counted from floor 
    public float Weight { get; set; } // Weight in ounces pr. portion
    public float Cups { get; set; } // Number of cups pr. poriton
    public float Rating { get; set; } // Rating of cereal
}
