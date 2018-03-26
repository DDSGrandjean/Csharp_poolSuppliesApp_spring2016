using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolSuppliesApp
{
    class PoolSupplies
    {
        const double GALLON_CONVERSION = 7.48;

        private double totalGallons;
        private double length;
        private double width;
        private double depth;
        private int clarifier;

        public PoolSupplies(){}

        public PoolSupplies(double aLength, double aWidth, double aDepth)
        {
            length = aLength;
            width = aWidth;
            depth = aDepth;
        }

        //Set value in method properties
        public double PoolLength{ set { length = value; } }
        public double PoolWidth { set { width = value; } }
        public double PoolDepth { set { depth = value; } }

        //Calculate the values
        public void Calculation()
        {
            double volume;
            volume = length * width * depth;
            totalGallons = volume * GALLON_CONVERSION;
            clarifier = (int)Math.Ceiling(totalGallons / 5000);
        }


        //Convert the results ToString() and return a string to display
        public override string ToString()
        {
            Calculation();
            return "*********************************\n" +
                   "Length is " + length + 
                   " - Width is " + width + 
                   " - Depth is " + depth + "\n" +
                   "Number of gallons " + totalGallons.ToString("n0") + "\n" +
                   clarifier + " Ounces of clarifier\n" +
                   "*********************************";
        }

    }
}
