using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dndLib
{
    public class DnDiceGroup
    {
        private readonly int bonus = 0;
        private readonly List<IDnDice> dice = new List<IDnDice>();
        private const string rePattern = @"((\d*)([dD]\d*))([+-]?\d*)";

        public int GetBonus()
        {
            return bonus;
        }

        public List<IDnDice> GetDice()
        {
            return dice;
        }

        public DnDiceGroup(string diceText)
        {
            Regex re = new Regex(rePattern);
            MatchCollection mc = re.Matches(diceText);
            int moltiplicatore = int.Parse(mc[0].Groups[2].Value);
            string tipoDado = mc[0].Groups[3].Value.ToUpper();
            int plus = int.Parse(mc[0].Groups[4].Value);

            object DnDie = Activator.CreateInstance(Type.GetType(string.Format("dndLib.{0}", tipoDado)));
            dice.Clear();
            for (int i = 0; i < moltiplicatore; i++)
            {
                if(DnDie is IDnDice)
                {
                    dice.Add(DnDie as IDnDice);
                }
            }

            bonus = plus;
        }
    }
}
