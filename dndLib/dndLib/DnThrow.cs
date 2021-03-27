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
        private bool luck = false;
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
            int result = 1;
            List<IDnDice> throws = new List<IDnDice>();

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

            return result;
        }

        public string GetName()
        {
            return singleDie.ToString();
        }
    }
}
