using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISellable
    {
        public string Name { get; }
        public decimal Price { get; }
    }
}
