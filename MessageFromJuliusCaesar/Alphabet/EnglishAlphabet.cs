﻿namespace MessageFromJuliusCaesar.Alphabet
{
    internal class EnglishAlphabet : IAlphabet
    {
        public char[] Alphabet =>
            new char[26]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z'
            };
    }
}