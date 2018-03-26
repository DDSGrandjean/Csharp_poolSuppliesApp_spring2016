using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolSuppliesApp
{
    class Main
    {
        static void Main(string[] args)
        {
            //Instantiate PoolSupplies class
            PoolSupplies poolSuplies = new PoolSupplies();

            //Get user input and send them to the class
            Console.Write("Enter length in feet: ");
            poolSuplies.PoolLength = double.Parse(Console.ReadLine());
            Console.Write("Enter width in feet: ");
            poolSuplies.PoolWidth = double.Parse(Console.ReadLine());
            Console.Write("Enter depth in feet: ");
            poolSuplies.PoolDepth = double.Parse(Console.ReadLine());

            //Display results from poolSupplies.ToString()
            Console.WriteLine(poolSuplies.ToString());
            Console.Read();
        }
    }
}
