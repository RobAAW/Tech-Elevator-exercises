using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming 
{
    class Tractor : ISingable
    {
        public string Name { get; }
        public string Sound { get; }

        
        public Tractor(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }
}
