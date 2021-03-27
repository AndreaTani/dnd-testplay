namespace dndLib
{
    public interface IDnDice
    {
        int Roll();
        void SetSides(int value);
        int GetSides();
    }
}