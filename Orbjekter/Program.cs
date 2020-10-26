using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekter
{
    class Program
    {
        class Frugt
        {
            public string frugt1 = "aeble";
            public string frugt2 = "paere";
        } 

        static void Main(string[] args)
        {
            Frugt objekt1 = new Frugt();
            Frugt objekt2 = new Frugt();
            Frugt objekt3 = new Frugt();

            Console.WriteLine(objekt1.frugt1);
            Console.WriteLine(objekt2.frugt2);
            Console.WriteLine(objekt3.frugt2);

            Console.ReadLine();
        }
    }
}
