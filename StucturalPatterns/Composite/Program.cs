using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var district = new Map() {Title = "serebryanka"};
            district.AddMapComponent(new ElementaryMapComponent(){Title = "Dom1"});
            district.AddMapComponent(new ElementaryMapComponent() { Title = "Gippo" });
            district.AddMapComponent(new ElementaryMapComponent() { Title = "Narhoz" });
            district.AddMapComponent(new ElementaryMapComponent() { Title = "TD Palesse" });
            district.AddMapComponent(new ElementaryMapComponent() { Title = "Sosedi" });

            var city = new Map(){Title = "Minsk"};
            city.AddMapComponent(district);
            city.Draw();

            var gippo = city.Find("Gippo");
            gippo.Draw();

            Console.ReadKey();
        }
    }
}
