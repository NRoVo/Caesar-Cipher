using System;
using System.Runtime.CompilerServices;
using CaesarCipher.Core.Alphabet;

namespace CaesarCipher.Core
{
    public class CaesarCipherImplementation
    {
        private readonly IAlphabet[] _alphabets;

        public CaesarCipherImplementation(params IAlphabet [] alphabets)
        {
            _alphabets = alphabets;
        }

        public string Encrypt(string message, int steps)
        {
            var result = message.ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                var currentCharacter = message[i];
                for (var j = 0; j < _alphabets.Length; j++)
                {
                    var currentAlphabet = _alphabets[j];
                    if (currentAlphabet.IsApplicable(currentCharacter))
                    {
                        result[i] = currentAlphabet.GetWithOffset(currentCharacter, steps);
                        break;
                    }
                }
            }
            return new string(result);
        }

        public string Decrypt(string message, int steps)
        {
            var result = message.ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                
            }
        }
        /*public static string Encrypt(string message, int key)
        {
            var result = new char[message.Length];

            for (var i = 0; i < message.Length; i++)
            {
                
                result[i] = Encrypt(message[i], key);
            }

            return new string(result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static char Encrypt(char letter, int key)
        {
            if (letter < 'A' || letter > 'Z')
            {
                return letter;
            }

            var letterAsNumber = letter - 'A';
            var encryptedLetter = (letterAsNumber + key) % 26;

            return (char) (encryptedLetter + 'A');
        }

        public static string Decrypt(string message, int key)
        {
            message = message.ToUpper();
            var result = new char[message.Length];

            for (var i = 0; i < message.Length; i++)
            {
                result[i] = Decrypt(message[i], key);
            }

            return new string(result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static char Decrypt(char letter, int key)
        {
            if (letter < 'A' || letter > 'Z')
            {
                return letter;
            }

            var letterAsNumber = letter - 'A';
            var decryptedLetter = (letterAsNumber - key + 26) % 26;

            return (char) (decryptedLetter + 'A');
        }

        public static void BruteForceDecrypt(string messageToHack)
        {
            for (int index = 0; index <= 26; index++)
            {
                Console.WriteLine(Decrypt(messageToHack, index));
            }
        }*/
    }
}