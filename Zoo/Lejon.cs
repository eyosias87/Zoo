/* Lejon-klassen*/
using System.Xml.Linq;
using Zoo;

public class Lejon : Djur
{
    public bool ÄrAlfaHane { get; set; } = false;

    public Lejon(string namn, int ålder, double vikt, string livsmiljö, bool ärVild, bool ärAlfaHane)
        : base(namn, ålder, vikt, livsmiljö, ärVild)
    {
        ÄrAlfaHane = ärAlfaHane;
    }

    public override void GörLjud()
    {
        Console.WriteLine($"{Namn} ryter!");
    }

    public void Jaga()
    {
        Console.WriteLine($"{Namn} jagar.");
    }
}

/* Orm-klassen*/
public class Orm : Djur
{
    public bool ÄrGiftig { get; set; } = true;

    public Orm(string namn, int ålder, double vikt, string livsmiljö, bool ärVild, bool ärGiftig)
        : base(namn, ålder, vikt, livsmiljö, ärVild)
    {
        ÄrGiftig = ärGiftig;
    }

    public override void GörLjud()
    {
        Console.WriteLine($"{Namn} väser!");
    }

    public void AvlägsnaHud()
    {
        Console.WriteLine($"{Namn} tappar huden.");
    }
}

/* Människa-klassen*/
public class Människa : Djur
{
    public string Språk { get; set; } = "Okänned";

    public Människa(string namn, int ålder, double vikt, string livsmiljö, bool ärVild, string språk)
        : base(namn, ålder, vikt, livsmiljö, ärVild)
    {
        Språk = språk;
    }

    public override void GörLjud()
    {
        Console.WriteLine($"{Namn} säger hej på {Språk}.");
    }

    public void Tänka()
    {
        Console.WriteLine($"{Namn} tänker.");
    }
}
