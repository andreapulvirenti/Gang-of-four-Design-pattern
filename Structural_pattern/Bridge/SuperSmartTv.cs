using System;

namespace Bridge
{
    public class SuperSmartTv
    {
        private IVideoSource _videoSource = null;

        public IVideoSource VideoSource{
            get => _videoSource;
            set => _videoSource = value;
        }


        public void ShowTvSource()
        {
            if (_videoSource == null)
                throw new System.Exception($"no video source found");

            Console.WriteLine(_videoSource.GetTvGuide());

        }

        public void PlayTv()
        {
            if (_videoSource == null)
                throw new System.Exception($"no video source found");

            Console.WriteLine(_videoSource.PlayVideo());
        }


    }
}