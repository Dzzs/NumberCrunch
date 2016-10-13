using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace NumberCrunch
{
    class GameClass
    {
        PriceGenerator priceGenerator = new PriceGenerator();

        public double ReturnPrice()
        {
            double value = priceGenerator.GetRandomDouble(0.75, 3.50);
            return value;
        }




    }
}
