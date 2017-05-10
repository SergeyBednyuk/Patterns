using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConsoleObserver : IObserver
    {
        public ConsoleColor Color { get; private set; }

        public ConsoleObserver(ConsoleColor color)
        {
            Color = color;
        }

        public void OnChange(Detector changedDetector)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(changedDetector.Value);
            Console.ForegroundColor = color;
        }
    }
}
