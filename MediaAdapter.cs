namespace UniversalMediaPlayer
{
    public class MediaAdapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower() == "mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
            else if (audioType.ToLower() == "vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else
            {
                throw new ArgumentException($"Invalid audio type: {audioType}", nameof(audioType));
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp4")
            {
                advancedMediaPlayer.PlayMp4(fileName);
            }
            else if (audioType.ToLower() == "vlc")
            {
                advancedMediaPlayer.PlayVlc(fileName);
            }
        }
    }
}
