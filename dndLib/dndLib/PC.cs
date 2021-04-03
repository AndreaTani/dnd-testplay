using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndLib
{
    public class PC
    {
        private Sextine scores;
        private Sextine modifiers;
        public readonly string Name;

        public enum Attributes
        {
            strength,
            dexterity,
            constitution,
            intelligence,
            wisdom,
            charisma
        }

        private static int ComputeModifier(int score)
        {
            return (int)Math.Floor((score - 10.0) / 2.0) ;
        }

        private Sextine ComputeAllModifiers()
        {
            int str = ComputeModifier(scores.strength);
            int dex = ComputeModifier(scores.dexterity);
            int cnt = ComputeModifier(scores.constitution);
            int itl = ComputeModifier(scores.intelligence);
            int wis = ComputeModifier(scores.wisdom);
            int cha = ComputeModifier(scores.charisma);

            return new Sextine(str, dex, cnt, itl, wis, cha);
        }

        public PC(Sextine stats, string name)
        {
            Name = name;
            scores = stats;
            modifiers = ComputeAllModifiers();
        }

        public Sextine GetAllScores()
        {
            return scores;
        }

        public Sextine GetAllModifiers()
        {
            return modifiers;
        }

        public int GetModifier(Attributes attribute)
        {
            int modifier = -1000;
            switch (attribute)
            {
                case Attributes.strength:
                    modifier = modifiers.strength;
                    break;
                case Attributes.dexterity:
                    modifier = modifiers.dexterity;
                    break;
                case Attributes.constitution:
                    modifier = modifiers.constitution;
                    break;
                case Attributes.intelligence:
                    modifier = modifiers.intelligence;
                    break;
                case Attributes.wisdom:
                    modifier = modifiers.wisdom;
                    break;
                case Attributes.charisma:
                    modifier = modifiers.charisma;
                    break;
            }
            return modifier;
        }
    }
}
