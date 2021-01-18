
namespace CaesarCipher.Core.Alphabet
{
    public class EnglishAlphabet : IAlphabet
    {
        public int AlphabetLength => 26;

        public bool IsApplicable(char character)
        {
            character = char.ToUpperInvariant(character);
            return character >= 'A' && character <= 'Z';
        }

        public char GetWithOffset(char character, int steps)
        {
            steps %= AlphabetLength;
            if (steps < 0)
            {
                steps += AlphabetLength;
            }

            var reference = char.IsUpper(character) ? 'A' : 'a';
            var letterAsNumber = character - reference;
            var encryptedLetter = (letterAsNumber + steps) % AlphabetLength;
            return (char) (encryptedLetter + reference);
        }
    }
}