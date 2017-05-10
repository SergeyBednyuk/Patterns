using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Map:IMapComponent
    {
        
        private readonly IList<IMapComponent> components =new List<IMapComponent>();
        public string Title { get; set; }

        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var item in components)
            {
                item.Draw();
            }
        }

        public void AddMapComponent(IMapComponent mapComponent)
        {
            components.Add(mapComponent);
        }

        public IMapComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            
            foreach (var item in components)
            {
                var elementaryComponent = item.Find(title);
                if (elementaryComponent != null)
                    return elementaryComponent;
            }
            return null;
        }
    }
}
