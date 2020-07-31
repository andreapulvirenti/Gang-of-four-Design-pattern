﻿using System;

namespace Bridge
{
    class Program
    {
        public const bool IsSmartTvLocalTv = true;

        static void Main(string[] args)
        {

            SuperSmartTv myTv = new SuperSmartTv();

            Console.WriteLine("Select A source to get TV Guide and Play");
            Console.WriteLine("1. Local Cable TV\n2. Netflix \n3. Sky");

            ConsoleKeyInfo input = Console.ReadKey();

            // Let us see what user has selected and select the video source accrodingly
            switch (input.KeyChar)
            {
                case '1':
                    myTv.VideoSource = new LocalTvSource();
                    break;

                case '2':
                    myTv.VideoSource = new NetflixTvSource();
                    break;

                case '3':
                    myTv.VideoSource = new SkyTvSource();
                    break;
            }

            myTv.ShowTvGuide();

            myTv.PlayTv();


            Console.WriteLine($"\n Normal smart TV");
            var smartTv = new SmartTv();
            smartTv.VideoSource = IsSmartTvLocalTv ? new LocalTvSource() : null; 
            smartTv.ShowBriefTVGuide();

            Console.ReadLine(); //some whitespace on output for readability
        }
    }
}
