
using System;
using System.Collections.Generic;

namespace Build
{
    public interface IBuilder
    {
        Product GetProduct();
        void Reset();
        void BuildPartA();
        
        void BuildPartB();
        
        void BuildPartC();

        
    }
}