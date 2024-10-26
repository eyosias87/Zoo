using Zoo;

class Program
{
    static void Main(string[] args)
    {
        /* Skapa några djur och växter*/
        Lejon lejon = new Lejon("Simba", 5, 190.5, "Savann", true, true);
        Orm orm = new Orm("Kaa", 2, 15, "Regnskog", true, true);
        Människa människa = new Människa("Olle", 30, 65, "Stad", false, "Finska");
        Bulldogg bulldogg = new Bulldogg("Bella", 4, 25, "Hus", false);

        /* Låt djuren göra sina ljud*/
        lejon.GörLjud();
        orm.GörLjud();
        människa.GörLjud();
        bulldogg.GörLjud();
        bulldogg.Snarka();

        /* Skapa en växt och låt den växa*/
        Växter växter = new Växter("Solros", 1.5, true);
        växter.Växa();
        växter.Fotosyntetisera();
    }
}
