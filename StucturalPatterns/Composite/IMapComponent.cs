using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IMapComponent
    {
        string Title { get; set; }
        void Draw();
        IMapComponent Find(string Title);

    }
}
