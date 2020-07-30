using System;
using System.Collections.Generic;

namespace Bridge
{
    public class LocalTvSource : IVideoSource
    {
        const string SOURCE_NAME = "Local cable TV";
        string IVideoSource.GetTvGuide(){
            return $"Getting TV guide from - {SOURCE_NAME}";
        }

        string IVideoSource.PlayVideo(){
            	return $"Playing - {SOURCE_NAME}";
        }

    }

    public class SkyTvSource : IVideoSource
    {
        const string SOURCE_NAME = "Sky";
        string IVideoSource.GetTvGuide(){
            return $"Getting TV guide from - {SOURCE_NAME}";
        }

        string IVideoSource.PlayVideo(){
            	return $"Playing - {SOURCE_NAME}";

        }
    }

     public class NetflixTvSource : IVideoSource
    {
        const string SOURCE_NAME = "Netflix";
        string IVideoSource.GetTvGuide(){
            return $"Getting TV guide from - {SOURCE_NAME}";
        }

        string IVideoSource.PlayVideo(){
            	return $"Playing - {SOURCE_NAME}";

        }
    }
}