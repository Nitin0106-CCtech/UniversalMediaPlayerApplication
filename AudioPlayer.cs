using System;

namespace UniversalMediaPlayer
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter? mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine($"Playing MP3 file: {fileName}");
            }
            else if (audioType.ToLower() == "mp4" ||
                     audioType.ToLower() == "vlc")
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Format '{audioType}' is not supported.");
            }
        }
    }
}
