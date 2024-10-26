using System.Xml.Linq;
using Zoo;

public class VildDjur : Djur
{
    public VildDjur(string namn, int ålder, double vikt, string livsmiljö)
        : base(namn, ålder, vikt, livsmiljö, true)
    {
    }

    public void Jaga()
    {
        Console.WriteLine($"{Namn} jagar i det vilda.");
    }
}

public class  TamDjur: Djur
{
    public TamDjur(string namn, int ålder, double vikt, string livsmiljö)
        : base(namn, ålder, vikt, livsmiljö, false)
    {
    }

    public void BliTämjad()
    {
        Console.WriteLine($"{Namn} håller på att tämjas.");
    }
}
