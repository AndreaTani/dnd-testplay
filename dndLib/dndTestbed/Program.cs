using System;
using System.Linq;
using dndLib;

namespace dndTestbed
{
    class Program
    {
        static void Main(string[] args)
        {
            var th = new DnThrow(new D20());

            int n = 1000000;

            int[] tiri = new int[n];

            for (int i = 0; i < n; i++)
            {
                tiri[i] = th.Throw();
            }

            for (int j = 1; j <= th.GetMax(); j++)
            {
                int c = tiri.Where(x => x.Equals(j)).Count();
                Console.WriteLine("{0}:{1}", j, c);
            }

            var media = tiri.Average();

            Console.WriteLine("La media di {1} tiri con un {2} è {0}", media, n, th.GetName());
        }
    }
}