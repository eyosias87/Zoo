public class Växter
{
    public string Namn { get; set; }
    public double Höjd { get; set; }
    public bool Blommar { get; set; }

    public Växter(string namn, double höjd, bool blommar)
    {
        Namn = namn;
        Höjd = höjd;
        Blommar = blommar;
    }

    public void Växa()
    {
        Console.WriteLine($"{Namn} växer.");
    }

    public void Fotosyntetisera()
    {
        Console.WriteLine($"{Namn} utför fotosyntes.");
    }
}
