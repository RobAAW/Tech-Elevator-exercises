using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        //get the name
        public string Name { get; }

        //get the sound
        public string Sound { get; }

        public void Tune();
    }
}
