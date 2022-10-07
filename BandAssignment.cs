using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_nit
{
    internal class BandAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your venue?");
            string venue = args[0];
            Console.WriteLine(Announce(venue));

        }
        static string Announce(string value)
        {
            return (value + " will have bands performing tonight.");
        }
    }
}
