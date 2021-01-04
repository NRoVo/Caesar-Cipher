namespace CaesarCipher.Core.Alphabet
{
    internal interface IAlphabet
    {
        
        bool IsApplicable(char character);

        char GetWithOffset(char character, int steps);
    }
}