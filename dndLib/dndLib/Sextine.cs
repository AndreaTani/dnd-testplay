using System;
using System.Reflection;

namespace dndLib
{
    public struct Sextine : IEquatable<Sextine>
    {
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;

        private static int AddToMax20(int a, int b)
        {
            return a + b > 20 ? 20 : a + b;
        }

        public Sextine(int str, int dex, int cnt, int itl, int wis, int cha)
        {
            strength = str;
            dexterity = dex;
            constitution = cnt;
            intelligence = itl;
            wisdom = wis;
            charisma = cha;
        }

        public override bool Equals(object obj)
        {
            return obj is Sextine sextine && Equals(sextine);
        }

        public bool Equals(Sextine other)
        {
            return strength == other.strength &&
                   dexterity == other.dexterity &&
                   constitution == other.constitution &&
                   intelligence == other.intelligence &&
                   wisdom == other.wisdom &&
                   charisma == other.charisma;
        }

        public static bool operator ==(Sextine left, Sextine right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Sextine left, Sextine right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(strength, dexterity, constitution, intelligence, wisdom, charisma);
        }

        public static Sextine operator +(Sextine left, Sextine right)
        {
            int str = AddToMax20(left.strength, right.strength);
            int dex = AddToMax20(left.dexterity, right.dexterity);
            int cnt = AddToMax20(left.constitution, right.constitution);
            int itl = AddToMax20(left.intelligence, right.intelligence);
            int wis = AddToMax20(left.wisdom, right.wisdom);
            int cha = AddToMax20(left.charisma, right.charisma);

            return new Sextine(str, dex, cnt, itl, wis, cha);
        }
    }
}
