using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxVolumeCalculatorPrøve;

namespace ConsoleApplicationBoxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 service = new Service1();
            Console.WriteLine("Volume: 1*2*5 ");
            Console.WriteLine(service.GetVolume(1,2,5));
            Console.WriteLine("/n");
            Console.WriteLine("Missing side: 20/(2*2) ");
            Console.WriteLine(service.GetSide(20, 2, 2));
            Console.ReadLine();

        }
    }
}
