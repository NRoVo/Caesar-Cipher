using System.Linq;
using  System;

namespace CaesarCipher.Core.Alphabet
{
    public class RussianAlphabet : IAlphabet
    {
        public int AlphabetLength => _alphabet.Length;
        private static readonly char[] _alphabet = {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };

        public bool IsApplicable(char character)
            => Array.IndexOf(_alphabet, char.ToUpperInvariant(character)) >= 0;

        public char GetWithOffset(char character, int steps)
        {
            steps %= AlphabetLength;
            if (steps < 0)
            {
                steps += AlphabetLength;
            }
            
            var result = _alphabet[(Array.IndexOf(_alphabet, char.ToUpperInvariant(character)) + steps) % _alphabet.Length];
            return char.IsUpper(character) ? result : char.ToLowerInvariant(result);
        }
    }
}