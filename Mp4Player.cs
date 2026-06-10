using System;

namespace UniversalMediaPlayer
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing MP4 file: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            // Not Supported
        }
    }
}
