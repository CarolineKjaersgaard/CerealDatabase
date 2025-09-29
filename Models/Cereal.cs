using System;
using CerealDatabase.Models;

public class Cereal
{
    public required string name { get; set; }
    public required string mfr { get; set; }
    public required string type { get; set; }
    public int calories { get; set; }
    public int protein { get; set; }
    public int fat { get; set; }
    public int sodium { get; set; }
    public float fiber { get; set; }
    public float carbo { get; set; }
    public int sugars { get; set; }
    public int potass { get; set; }
    public int vitamins { get; set; }
    public int shelf { get; set; }
    public float weight { get; set; }
    public float cups { get; set; }
    public float rating { get; set; }
}
