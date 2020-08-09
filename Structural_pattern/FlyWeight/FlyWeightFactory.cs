using System;
using System.Collections.Generic;
namespace FlyWeight
{
    public class FlyWeightFactory
    {
        private Dictionary<char, AFlyweightSlider> _sliders = new Dictionary<char, AFlyweightSlider>();

        public AFlyweightSlider GetSlider(char key)
        {
            AFlyweightSlider slider = null;
            if (this._sliders.ContainsKey(key))
                return this._sliders[key];

            switch (key)
            {
                case 'B': slider = new BaconMaster(); break;
                case 'V': slider = new VeggieSlider(); break;
                case 'Q': slider = new BBQSlider(); break;
                default: slider = new BaconMaster(); break;
            }
            _sliders.Add(key, slider);
            return slider;
        }
    }
}