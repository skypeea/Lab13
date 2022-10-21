using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building b = new Building("Moscow", 64, 12, 15);
            Console.WriteLine(b.Print());
            MultiBuilding mb = new MultiBuilding("SPb", 128, 24, 32, 15);
            Console.WriteLine(mb.Print());
            Console.ReadLine();
    
        }
    }
}
