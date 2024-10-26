using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
        // Husdjursklass som ärver från Hund
        public class Hund : Djur
    {
            public string Ras { get; set; }

            public Hund(string namn, int ålder, double vikt, string livsmiljö, bool ÄrVild, string ras)
                : base(namn, ålder, vikt, livsmiljö, ÄrVild)
            {
                Ras = ras;
            }

            public override void GörLjud()
            {
                Console.WriteLine($"{Namn}, det {Ras}, skäller!");
            }
        }

        // Hundvarianter
        public class Bulldogg : Hund
        {
            public Bulldogg(string namn, int ålder, double vikt, string livsmiljö, bool ÄrVild)
                : base(namn, ålder, vikt, livsmiljö, ÄrVild, "Bulldogg")
            {
            }

            public void Snarka()
            {
                Console.WriteLine($"{Namn}, Bulldoggen, snarkar högt.");
            }
        }

        public class Chihuahua : Hund
        {
            public Chihuahua(string namn, int ålder, double vikt, string livsmiljö, bool ärVild)
                : base(namn, ålder, vikt, livsmiljö, ärVild, "Chihuahua")
            {
            }

            public void Shake()
            {
                Console.WriteLine($"{Namn}, Chihuahua, skakar nervöst.");
            }
        }

    
}
