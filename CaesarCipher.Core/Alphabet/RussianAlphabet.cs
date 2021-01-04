using System.Linq;
using  System;

namespace CaesarCipher.Core.Alphabet
{
    internal class RussianAlphabet : IAlphabet
    {
        private static readonly char[] _alphabet = new char[33]
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };
        
        public bool IsApplicable(char character) 
            => _alphabet.Contains(char.ToUpperInvariant(character));

        public char GetWithOffset(char character, int steps)
        {
            var alphabetLength = _alphabet.Length;
            steps %= alphabetLength;
            if (steps < 0)
            {
                steps += alphabetLength;
            }
            
            return _alphabet[(Array.IndexOf(_alphabet, character) + steps) % _alphabet.Length];
        }
    }
}