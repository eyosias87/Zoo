namespace Zoo
{
    using System;

public class Djur
{
    /* Egenskaper som alla djur delar*/
    public string Namn { get; set; }
    public int Ålder { get; set; }
    public double Vikt { get; set; }
    public string Livsmiljö { get; set; }
    public bool ÄrVild { get; set; }

    /* Konstruktor för basklassen*/
    public Djur(string namn, int ålder, double vikt, string livsmiljö, bool ärVild)
    {
        Namn = namn;
        Ålder = ålder;
        Vikt = vikt;
        Livsmiljö = livsmiljö;
        ÄrVild = ärVild;
    }

    /* Metoder som alla djur delar*/
    public virtual void Äta()
    {
        Console.WriteLine($"{Namn} äter.");
    }

    public virtual void Sova()
    {
        Console.WriteLine($"{Namn} sover.");
    }

    public virtual void Röra()
    {
        Console.WriteLine($"{Namn} rör sig.");
    }

    /* Alla djur ska kunna göra ljud*/
    public virtual void GörLjud()
    {
        Console.WriteLine($"{Namn} gör ett ljud.");
    }
}

}
