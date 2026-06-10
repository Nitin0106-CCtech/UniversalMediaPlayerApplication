using System;

namespace UniversalMediaPlayer
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing VLC file: {fileName}");
        }

        public void PlayMp4(string fileName)
        {
            // Not Supported
        }
    }
}
