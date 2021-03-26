using System;

namespace dndLib
{
    public class Dice
    {
        private int sides;

        public int GetSides()
        {
            return sides;
        }

        public void SetSides(int value)
        {
            sides = value;
        }

        public int Roll()
        {
            Random random = new Random((int)DateTime.UtcNow.Ticks);
            int value = random.Next(1, GetSides() + 1);
            return value;
        }
    }
}
