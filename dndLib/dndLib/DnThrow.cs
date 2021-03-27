using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndLib
{
    public class DnThrow
    {
        private enum DnType
        {
            SingleDie,
            DiceString
        }

        private bool adv = false;
        private bool dis = false;
        private DnType thrtype;
        private IDnDice singleDie;
        private string diceString;

        public DnThrow(IDnDice dnDice)
        {
            thrtype = DnType.SingleDie;
            singleDie = dnDice;
        }

        public DnThrow(string diceText)
        {
            thrtype = DnType.DiceString;
            diceString = diceText;
        }

        public void SetAdv()
        {
            adv = true;
        }

        public void SetDis()
        {
            dis = true;
        }

        public int GetMax()
        {
            return singleDie.GetSides();
        }

        public int Throw()
        {
            int result;
            DnDiceGroup diceGroup;

            if (thrtype == DnType.SingleDie)
            {
                result = singleDie.Roll();
                if (adv ^ dis)
                {
                    int r = singleDie.Roll();
                    if ((adv & r > result) | (dis & r < result))
                    {
                        result = r;
                    }
                }
            } 
            else //if (thrtype == DnType.DiceString)
            {
                result = 0;
                diceGroup = new DnDiceGroup(diceString);
                foreach(var d in diceGroup.GetDice())
                {
                    result += d.Roll();
                }
                result += diceGroup.GetBonus();
            }

            return result;
        }

        public string GetName()
        {
            return singleDie.ToString();
        }
    }
}
