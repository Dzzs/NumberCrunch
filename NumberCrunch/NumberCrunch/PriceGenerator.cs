using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCrunch
{
    class PriceGenerator
    {
        Random random = new Random();

        public double GetRandomDouble(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

    }
}
