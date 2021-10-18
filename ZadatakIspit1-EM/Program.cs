using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakIspit1_EM
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport sport1 = new Sport("Nogomet", true, 11);
            Sport sport2 = new Sport("Vaterpolo", true, 7);
            Sport sport3 = new Sport("Curling", false, 5);


            Console.ReadKey();
        }
    }
}
