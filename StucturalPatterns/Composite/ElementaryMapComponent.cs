using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ElementaryMapComponent :IMapComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title);
        }

        public IMapComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }
}
