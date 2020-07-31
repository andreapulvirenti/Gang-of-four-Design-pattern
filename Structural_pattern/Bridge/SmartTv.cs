using System;

namespace Bridge
{
    public class SmartTv
    {
        private IVideoSource _videoSource = null;

        public IVideoSource VideoSource
        {
            get => _videoSource;
            set => _videoSource = value;
        }

        public void ShowBriefTVGuide()
        {
            if (_videoSource == null)
                throw new System.Exception("No VideoSource Found");

            Console.WriteLine($" This is small tv guide: {VideoSource.GetTvGuide()}");
        }
    }
}