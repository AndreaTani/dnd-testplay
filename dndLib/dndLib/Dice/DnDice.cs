using System;

namespace dndLib
{
    public class DnDice : IDnDice
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

        public override string ToString()
        {
            return String.Format("D{0}", sides);
        }
    }
}
