using System;
using System.Linq;
using dndLib;

namespace dndTestbed
{
    class Program
    {
        static void Main(string[] args)
        {
            #region verifica dadi
            //var th = new DnThrow(new D8());

            //int n = 1000000;

            //int[] tiri = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    tiri[i] = th.Throw();
            //}

            //for (int j = tiri.Min(); j <= tiri.Max(); j++)
            //{
            //    int c = tiri.Where(x => x.Equals(j)).Count();
            //    Console.WriteLine("{0}:{1}", j, c);
            //}

            //var media = tiri.Average();

            //Console.WriteLine("La media di {1} tiri con un {2} è {0}", media, n, th.GetName());
            #endregion

            #region verifica dicetext

            string diceText = "3d8+5";
            var th = new DnThrow(diceText);

            int n = 100000;

            int[] tiri = new int[n];

            for (int i = 0; i < n; i++)
            {
                tiri[i] = th.Throw();
            }

            for (int j = tiri.Min(); j <= tiri.Max(); j++)
            {
                int c = tiri.Where(x => x.Equals(j)).Count();
                Console.WriteLine("{0}:{1}", j, c);
            }

            var media = tiri.Average();

            Console.WriteLine("La media di {1} tiri {2} è {0}", media, n, diceText);

            #endregion
        }
    }
}