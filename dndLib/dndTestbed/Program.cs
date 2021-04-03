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

            //string diceText = "3d8+5";
            //var th = new DnThrow(diceText);

            //int n = 100000;

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

            //Console.WriteLine("La media di {0} tiri {1} è {2}", n, diceText, media);

            #endregion

            #region Verifica PC

            PC fighter = new PC(new Sextine (16, 9, 15, 11, 13, 14), "Guerrino");

            Console.WriteLine("Name: {0}", fighter.Name);
            Console.WriteLine("Stength: Score {0} - Modifier {1}", fighter.GetAllScores().strength,  fighter.GetModifier(PC.Attributes.strength));
            Console.WriteLine("Dexterity: Score {0} - Modifier {1}", fighter.GetAllScores().dexterity,  fighter.GetModifier(PC.Attributes.dexterity));
            Console.WriteLine("Constitution: Score {0} - Modifier {1}", fighter.GetAllScores().constitution,  fighter.GetModifier(PC.Attributes.constitution));
            Console.WriteLine("Intelligence: Score {0} - Modifier {1}", fighter.GetAllScores().intelligence,  fighter.GetModifier(PC.Attributes.intelligence));
            Console.WriteLine("Wisdom: Score {0} - Modifier {1}", fighter.GetAllScores().wisdom,  fighter.GetModifier(PC.Attributes.wisdom));
            Console.WriteLine("Charisma: Score {0} - Modifier {1}", fighter.GetAllScores().charisma,  fighter.GetModifier(PC.Attributes.charisma));

            #endregion

        }
    }
}