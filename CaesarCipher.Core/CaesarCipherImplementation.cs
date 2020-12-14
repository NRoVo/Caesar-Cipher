using System;

namespace CaesarCipher.Core
{
    public static class CaesarCipherImplementation
    {
        public static string Encrypt(string message, int key)
        {
            message = message.ToUpper();
            var encryptedMessage = "";

            for (int index = 0; index < message.Length; index++)
            {
                encryptedMessage += Encrypt(message[index], key);
            }

            return encryptedMessage;
        }

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
            var decryptedMessage = "";

            for (int index = 0; index < message.Length; index++)
            {
                decryptedMessage += Decrypt(message[index], key);
            }

            return decryptedMessage;
        }

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
        }
    }
}