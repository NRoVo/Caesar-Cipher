using System;

namespace CaesarCipher.Core.Alphabet
{
    internal class EnglishAlphabet : IAlphabet
    {
        public bool IsApplicable(char character)
        {
            character = char.ToUpperInvariant(character);
            return character >= 'A' && character <= 'Z';
        }

        public char GetWithOffset(char character, int steps)
        {
            const int alphabetLength = 26;
            steps %= alphabetLength;
            if (steps < 0)
            {
                steps += alphabetLength;
            }
            
            var letterAsNumber = character - 'A';
            var encryptedLetter = (letterAsNumber + steps) % alphabetLength;
            return (char) (encryptedLetter + 'A');
        }
    }
}