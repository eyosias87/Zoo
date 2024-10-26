// Däggdjursklass
using System.Xml.Linq;
using Zoo;

public class DäggOchReptiler : Djur
{
    public DäggOchReptiler(string namn, int ålder, double vikt, string livsmiljö, bool ärVild)
        : base(namn, ålder, vikt, livsmiljö, ärVild)
    {
    }

    public void GeUpphov()
    {
        Console.WriteLine($"{Namn} föder barn.");
    }
}

// Reptilklass
public class Reptiler : Djur
{
    public Reptiler(string name, int age, double weight, string habitat, bool isWild)
        : base(name, age, weight, habitat, isWild)
    {
    }

    public void VärpaÄgg()
    {
        Console.WriteLine($"{Namn} lägger ägg.");
    }
}
