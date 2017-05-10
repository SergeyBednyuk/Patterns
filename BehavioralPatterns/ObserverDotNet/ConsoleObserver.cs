using System;


namespace ObserverDotNet
{
    class ConsoleObserver : IObserver<Detector>
    {
        public ConsoleColor Color { get; private set; }

        public ConsoleObserver(ConsoleColor color)
        {
            Color = color;
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        { 
        }

        public void OnNext(Detector changedDetector)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(changedDetector.Value);
            Console.ForegroundColor = color;
        }
    }
}
