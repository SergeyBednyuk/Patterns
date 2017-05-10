using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SoundPlayerAdapter : IAudioPlayer
    {
        private readonly SoundPlayer player = new SoundPlayer();
        public void Load(string file)
        {
            player.SoundLocation = file;
            player.Load();
        }

        public void Play()
        {
            player.Play();
        }
    }
}
