using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IAudioPlayer player=new SoundPlayerAdapter();
            player.Load(@"D:\Vilchuk\Patterns\StucturalPatterns\StucturalPatterns\Adapter\res\jpark.wav");
            player.Play();
            Console.Read();
        }
    }
}
