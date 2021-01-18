namespace CaesarCipher.Core.Alphabet
{
    public interface IAlphabet
    {
        int AlphabetLength { get; }

        bool IsApplicable(char character);

        char GetWithOffset(char character, int steps);
    }
}